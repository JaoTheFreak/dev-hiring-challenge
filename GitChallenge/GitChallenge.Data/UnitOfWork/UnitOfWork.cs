using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitChallenge.Data.Data;
using GitChallenge.Domain.Interfaces;

namespace GitChallenge.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<string, dynamic> _repositories;

        private readonly DatabaseContext _dbContext;

        public UnitOfWork(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Rollback()
        {
            //empty
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() >= 0;
        }

        public async Task<bool> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if(_repositories == null)
                _repositories = new Dictionary<string, dynamic>();

            var repositoryTypeName = typeof(T).Name;

            if (_repositories.ContainsKey(repositoryTypeName))
                return (IRepository<T>) _repositories[repositoryTypeName];

            var repositoryType = typeof(IRepository<>);

            _repositories.Add(repositoryTypeName, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbContext));

            return _repositories[repositoryTypeName];
        }
    }
}

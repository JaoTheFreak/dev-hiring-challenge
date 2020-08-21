using GitChallenge.Domain.Interfaces;
using GitChallenge.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using GitChallenge.Data.Data;

namespace GitChallenge.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext _dbContext;

        public Repository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(ICollection<T> entitiesToDelete)
        {
            _dbContext.Entry(entitiesToDelete).State = EntityState.Deleted;
        }

        public void Delete(T entityToDelete)
        {
            _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
        }

        public void Delete(object id)
        {
            _dbContext.Set<T>().Remove(_dbContext.Set<T>().Find(id));
        }

        public IReadOnlyList<T> Find(Specification<T> filterSpecification, PagingSpecification pagingSpecification = null)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (filterSpecification != null)
                query = query.Where(filterSpecification.ToExpression());

            if (pagingSpecification != null)
                query = query.Skip(pagingSpecification.Skip).Take(pagingSpecification.Take);

            return query.ToList();
        }

        public async Task<IReadOnlyList<T>> FindAsync(Specification<T> filterSpecification, PagingSpecification pagingSpecification = null)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (filterSpecification != null)
                query = query.Where(filterSpecification.ToExpression());

            if (pagingSpecification != null)
                query = query.Skip(pagingSpecification.Skip).Take(pagingSpecification.Take);

            return await query.ToListAsync();
        }
        
        public T FindById(object id)
        {
            return _dbContext.Find<T>(id);
        }

        public async Task<T> FindByIdAsync(object id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public void Insert(ICollection<T> entitiesToCreate)
        {
            
        }

        public Task InsertAsync(ICollection<T> entitiesToCreate)
        {
            throw new NotImplementedException();
        }

        public void Update(ICollection<T> entitiesToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ICollection<T> entitiesToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entityToCreate)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entityToCreate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

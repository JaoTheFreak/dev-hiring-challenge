using System.Threading.Tasks;

namespace GitChallenge.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Rollback();

        bool Commit();

        Task<bool> CommitAsync();

        IRepository<T> Repository<T>() where T : class;
    }
}

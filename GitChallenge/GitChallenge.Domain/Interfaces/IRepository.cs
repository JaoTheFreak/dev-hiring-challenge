using GitChallenge.Domain.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitChallenge.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Delete(ICollection<T> entitiesToDelete);
        void Delete(T entityToDelete);
        void Delete(object id);
        IReadOnlyList<T> Find(Specification<T> filterSpecification, PagingSpecification pagingSpecification = null);
        Task<IReadOnlyList<T>> FindAsync(Specification<T> filterSpecification, PagingSpecification pagingSpecification = null);
        T FindById(object id);
        Task<T> FindByIdAsync(object id);
        void Insert(ICollection<T> entitiesToCreate);
        Task InsertAsync(ICollection<T> entitiesToCreate);
        void Update(ICollection<T> entitiesToUpdate);
        Task UpdateAsync(ICollection<T> entitiesToUpdate);
        void Insert(T entityToCreate);
        Task InsertAsync(T entityToCreate);
        void Update(T entityToUpdate);
        Task UpdateAsync(T entityToUpdate);
    }
}

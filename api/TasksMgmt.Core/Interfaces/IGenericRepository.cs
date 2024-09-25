using System.Linq.Expressions;

namespace TasksMgmt.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAllAsync();

        T GetByGuidAsync(Guid guid);

        IQueryable<T> SelectAsync(Expression<Func<T, bool>> predicate);

        T CreateAsync(T entity);

        T UpdateAsync(T entity);

        void DeleteAsync(Guid id);
    }
}

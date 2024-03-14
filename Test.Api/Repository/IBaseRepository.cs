using System.Linq.Expressions;

namespace Test.Api.Repository
{
    public interface IBaseRepository<T>
    {
        public Task<T> Create(T entity);
        public Task<T> GetByAny(Expression<Func<T, bool>> expression);
        public Task<List<T>> GetAll();
        public Task<bool> Delete(Expression<Func<T, bool>> expression);
        public Task<T> Update(T entity);

    }
}

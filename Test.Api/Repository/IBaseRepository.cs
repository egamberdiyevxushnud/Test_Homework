using System.Linq.Expressions;

namespace Test.Api.Repository
{
    public interface IBaseRepository<T>
    {
        public Task<T> Create(T entity);
        public Task<T> GetById(int id);
        public Task<List<T>> GetAll();
        public Task<T> Delete(T entity);
        public Task<T> Update(T entity);

    }
}

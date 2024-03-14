using System.Linq.Expressions;
using Test.Api.Entity.Car;

namespace Test.Api.CarServeces
{
    public interface IcarServece
    {
        Task<Car> CreateAsync(Car car);
        Task<Car> GetById(int id);
        Task<List<Car>> GetAllAsync();
        Task<bool> Delete(Expression<Func<Car, bool>> expression);
        Task<Car> UpdateAsync(int id, CarDTO carDTO);
    }
}

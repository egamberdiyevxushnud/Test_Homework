using System.Linq.Expressions;
using Test.Api.Entity.Car;

namespace Test.Api.CarServeces
{
    public interface IcarServece
    {
        Task<Car> CreateAsync(Car car);
        Task<Car> GetById(int id);
        Task<List<Car>> GetAllAsync();
        Task<Car> Delete(int id);
        Task<Car> UpdateAsync(int id, CarDTO carDTO);
    }
}

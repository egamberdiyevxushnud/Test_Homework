using System.Linq.Expressions;
using Test.Api.Entity.Car;
using Test.Api.Repository;

namespace Test.Api.CarServeces
{
    public class CarServece : IcarServece
    {
        private readonly IcarRepository _icarRepository;

        public CarServece(IcarRepository icarRepository)
        {
            _icarRepository = icarRepository;
        }

        public async Task<Car> CreateAsync(Car carDTO)
        {
            var model = new Car()
            {
                Name = carDTO.Name,
                Salary = carDTO.Salary,

            };

            var result = await _icarRepository.Create(model);
            return result;
        }

        public Task<bool> Delete(Expression<Func<Car, bool>> expression)
        {
            var result = _icarRepository.Delete(expression);
            return result;
        }

        public Task<List<Car>> GetAllAsync()
        {
            var result = _icarRepository.GetAll();
            return result;
        }

        public async Task<Car> GetById(int id)
        {
            var result = await _icarRepository.GetByAny(x => x.Id == id);
            return result;
        }

        public async Task<Car> UpdateAsync(int id, CarDTO carDTO)
        {
            var result = await _icarRepository.GetByAny(x => x.Id == id);
            if (result != null)
            {
                result.Name = carDTO.Name;
                result.Salary = carDTO.Salary;

                var res = _icarRepository.Update(result);

                return result;
            }

            return new Car();
            


        }
    }
}

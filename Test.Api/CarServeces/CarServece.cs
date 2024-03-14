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

        public async Task<Car> Delete(int id)
        {
            var result = _icarRepository.GetById(id);
            return await _icarRepository.Delete(result.Id);
        }

        public Task<List<Car>> GetAllAsync()
        {
            var result = _icarRepository.GetAll();
            return result;
        }

        public async Task<Car> GetById(int id)
        {
            var result = await _icarRepository.GetById(id);
            return result;
        }

        public async Task<Car> UpdateAsync(int id, CarDTO carDTO)
        {
            var result = await _icarRepository.GetById(id);
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

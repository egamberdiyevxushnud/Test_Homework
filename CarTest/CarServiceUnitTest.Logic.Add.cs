using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Api.Entity.Car;

namespace CarTest
{
    public partial class CarServiceUnitTest
    {
        [Fact]
        public async Task CardAddProduct()
        {
            var input = new Car()
            {
                Salary = 15000,
                Name = "Jentra"
            };

            var resultcar = new Car()
            {
                Salary = 15000,
                Name = "Jentra"
            };

            _carRepositoryMock.Setup(x => x.Create(input))
                .ReturnsAsync(resultcar);

            var outputcar = await _icarServece.CreateAsync(input);

            Assert.Equal(resultcar.Name, input.Name);
            Assert.Equal(resultcar.Salary, input.Salary);
        }
        [Fact]
        public async Task ShouldCardDelete()
        {
            var input = new Car()
            {
                Id = 1,
                Salary = 15000,
                Name = "Jentra"
            };

            var resultcar = new Car()
            {
                Id = input.Id,
                Salary = input.Salary,
                Name = input.Name
            };

            _carRepositoryMock.Setup(x => x.Delete(input.Id)
                .ReturnsAsync(resultcar);

            var outputcar = await _icarServece.Delete(input);

            Assert.Equal(resultcar.Name, input.Name);
            Assert.Equal(resultcar.Salary, input.Salary);
        }
        [Fact]
        public async Task ShouldCardUpdate()
        {
            var input = new Car()
            {
                Id = 1,
                Salary = 15000,
                Name = "Jentra"
            };

            var resultcar = new Car()
            {
                Id = input.Id,
                Salary = input.Salary,
                Name = input.Name
            };

            _carRepositoryMock.Setup(x => x.Update(input.Id)
                .ReturnsAsync(resultcar);

            var outputcar = await _icarServece.UpdateAsync(input);

            Assert.Equal(resultcar.Name, input.Name);
            Assert.Equal(resultcar.Salary, input.Salary);
        }
        [Fact]
        public async Task ShouldCarGetById()
        {
            var input = new Car()
            {
                Id = 1,
                Salary = 15000,
                Name = "Jentra"
            };

            var resultcar = new Car()
            {
                Id = input.Id,
                Salary = input.Salary,
                Name = input.Name
            };

            _carRepositoryMock.Setup(x => x.GetByAny(input.Id)
                .ReturnsAsync(resultcar);

            var outputcar = await _icarServece.GetById(input);

            Assert.Equal(resultcar.Name, input.Name);
            Assert.Equal(resultcar.Salary, input.Salary);
        }

    }

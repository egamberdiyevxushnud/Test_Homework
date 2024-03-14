using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Api.CarServeces;
using Test.Api.Repository;

namespace CarTest
{
    public partial class CarServiceUnitTest
    {
        private readonly IcarServece _icarServece;
        private readonly Mock<IcarRepository> _carRepositoryMock;

        public CarServiceUnitTest()
        {
            _carRepositoryMock = new Mock<IcarRepository>();
            _icarServece = new CarServece(_carRepositoryMock.Object);
        }
    }
}

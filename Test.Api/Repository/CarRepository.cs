using Test.Api.Data;
using Test.Api.Entity.Car;

namespace Test.Api.Repository
{
    public class CarRepository : BaseRepository<Car>, IcarRepository
    {
        public CarRepository(AppDbContext context) : base(context)
        {
        }
    }
}

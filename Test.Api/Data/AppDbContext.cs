using Microsoft.EntityFrameworkCore;
using Test.Api.Entity.Car;

namespace Test.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }

    }
}

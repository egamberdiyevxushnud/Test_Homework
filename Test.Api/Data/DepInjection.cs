using Microsoft.EntityFrameworkCore;
using Test.Api.CarServeces;
using Test.Api.Repository;

namespace Test.Api.Data
{
    public static class DepInjection
    {
         public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IcarServece, CarServece>();
            services.AddScoped<IcarRepository, CarRepository>();
            return services;
        }

    }
}

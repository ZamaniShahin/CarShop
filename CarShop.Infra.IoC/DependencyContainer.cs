using CarShop.Application.Interfaces;
using CarShop.Application.Services;
using CarShop.Domain.Interfaces;
using CarShop.Infra.Data.Context;
using CarShop.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICarCategoryService, CarCategoryService>();
            services.AddScoped<ICarService, CarService>();

            //Infrastructure.Data Layer 
            services.AddScoped<ICarCategoryRepository, CarCategoryRepository>();
            services.AddScoped<ICarRepository, CarRepository>();

            IConfiguration configuration = services.BuildServiceProvider().GetService<IConfiguration>();
            services.AddDbContext<ShopContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CarShopDbConnection"));
            });

        }
    }
}

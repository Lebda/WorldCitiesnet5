using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldCities.Models;

namespace WorldCities.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<WorldCitiesDbContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection"), b =>
                    b.MigrationsAssembly("WorldCities")));
    }
}

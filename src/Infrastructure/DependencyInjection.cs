using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.ConfigureDatabase(config);
            services.ConfigureInjection();
        }

        private static void ConfigureDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("SqlServer")));
        }

        private static void ConfigureInjection(this IServiceCollection services)
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}

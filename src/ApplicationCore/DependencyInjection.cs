using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public static class DependencyInjection
    {
        public static void AddApplicationCore(this IServiceCollection services)
        {
            services.ConfigureInjection();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        private static void ConfigureInjection(this IServiceCollection services)
        {
            
        }
    }
}

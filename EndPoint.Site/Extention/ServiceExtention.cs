using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Extention
{
    public static class ServiceExtention
    {
        public static void ConfigureRepositoryHuman(this IServiceCollection services)
        {
            //services.AddScoped<IMyGenericRepository<Human>, HumanRepository>();
        }
    }
}

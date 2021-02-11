using Microsoft.Extensions.DependencyInjection;
using Si2020BLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Si2020BLCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterBusinessServices(
           this IServiceCollection services
           )
        {

            services.AddTransient<IEsempioService, EsempioService>();

            return services;
        }
    }
}

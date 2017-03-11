using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCoreInfrastructure(this IServiceCollection services)
        {
            //services.AddTransient<IConcrete, Concrete>();
            return services;
        }
    }
}

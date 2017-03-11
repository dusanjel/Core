using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Infrastructure.IoC;

namespace Core.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCoreDomain(this IServiceCollection services)
        {
            //services.AddTransient<IGetMeRepo, GetMe>();

            services.AddCoreInfrastructure();
            return services;
        }
    }
}

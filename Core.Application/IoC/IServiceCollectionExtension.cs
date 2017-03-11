
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Infrastructure.IoC;
using Core.Domain.IoC;
using Core.Domain.Interfaces;
using Core.Domain.Services;

namespace Core.Application.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCoreApplication(this IServiceCollection services)
        {
            services.AddTransient<ICustomerDomService, CustomerDomService>();            

            services.AddCoreDomain();
            services.AddCoreInfrastructure();
            return services;
        }
    }
}

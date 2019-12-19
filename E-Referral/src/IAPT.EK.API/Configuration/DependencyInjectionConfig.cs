using System;
using Microsoft.Extensions.DependencyInjection;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Notifications;
using IAPT.EK.Business.Services;
using IAPT.EK.Data.Repository;

namespace IAPT.EK.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection DIConfiguration(this IServiceCollection services)
        {

            services.AddScoped<IEthnicCategoryRepository, EthnicCategoryRepository>();
            services.AddScoped<IEthnicCategoryServices, EthnicCategoryServices>();
            services.AddScoped<IReligiousGroupRepository, ReligiousGroupRepository>();
            services.AddScoped<IReligiousGroupServices, ReligiousGroupServices>();
            services.AddScoped<IDisabilityCodeRepository, DisabilityCodeRepository>();
            services.AddScoped<IDisabilityCodeServices, DisabilityCodeServices>();

            services.AddScoped<INotify, Notify>();

            return services;
        }
    }
}

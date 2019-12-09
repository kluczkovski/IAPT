using System;
using Microsoft.Extensions.DependencyInjection;
using Referral.EK.Business.Interfaces;
using Referral.EK.Business.Notifications;
using Referral.EK.Business.Services;
using Referral.EK.Data.Repository;

namespace Referral.EK.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection DIConfiguration(this IServiceCollection services)
        {

            services.AddScoped<IEthnicCategoryRepository, EthnicCategoryRepository>();
            services.AddScoped<IEthnicCategoryServices, EthnicCategoryServices>();
            services.AddScoped<INotify, Notify>();

            return services;
        }
    }
}

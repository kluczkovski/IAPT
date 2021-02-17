using System;
using Microsoft.Extensions.DependencyInjection;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Notifications;
using IAPT.EK.Business.Services;
using IAPT.EK.Data.Repository;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

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
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICityServices, CityServices>();
            services.AddScoped<ICCGCodeRepository, CCGCodeRepository>();
            services.AddScoped<ICCGCodeSerices, CCGCodeServices>();
            services.AddScoped<IGPPracticeRepository, GPPracticeRepository>();
            services.AddScoped<IGPPracticeServices, GPPracticeServices>();
            services.AddScoped<IeReferralRepository, eReferralRepository>();
            services.AddScoped<IeReferralServices, eReferralServices>();
            services.AddScoped<INotify, Notify>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}

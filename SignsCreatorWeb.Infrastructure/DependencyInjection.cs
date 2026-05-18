using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IKompasService, KompasService>();

            return services;
        }
    }
}

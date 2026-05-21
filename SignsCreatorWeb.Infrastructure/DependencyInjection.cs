using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Application.Services;
using SignsCreatorWeb.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SignsCreatorWebContext>(options=>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ISignsCreatorWebContext>(provider => provider.GetRequiredService<SignsCreatorWebContext>());
            services.AddScoped<DbInitializer>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddSingleton<IRabbitMQService, RabbitMQService>();

            return services;
        }
    }
}

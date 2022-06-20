﻿using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.Application.Services;
using SharedKernel.Domain.Services;

namespace SharedKernel.Application.Extensions
{
    /// <summary>Класс-расширение для <see cref="IServiceCollection"/></summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>Добавление общих сервисов уровня приложения</summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <param name="configuration"><see cref="IConfiguration"/></param>
        /// <returns><seealso cref="IServiceCollection"/></returns>
        public static IServiceCollection AddSharedKernelApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(services.GetType());

            // шина событий
            services.AddScoped<IEventBusService, EventBusService>();

            return services;
        }
    }
}
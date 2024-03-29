﻿using Common.Application.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Customers.Application.Extensions;

/// <summary>Класс-расширение для <see cref="IServiceCollection"/></summary>
public static class ServiceCollectionExtensions
{
    /// <summary>Добавление сервисов уровня приложения</summary>
    /// <param name="services"><see cref="IServiceCollection"/></param>
    /// <param name="configuration"><see cref="IConfiguration"/></param>
    /// <returns><seealso cref="IServiceCollection"/></returns>
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCommonApplication(configuration);

        // обработчики команд
        /*services.AddScoped<IRequestHandler<UserSignUpCommand, UserSignedUpEvent>, UserSignUpCommandHandler>();*/

        // обработчики запросов
        /*services.AddScoped<IRequestHandler<ExampleQuery, ExampleQueryResult>, ExampleQueryHandler>();*/

        // обработчики событий
        /*services.AddScoped<INotificationHandler<Event<ExampleEvent>>, ExampleEventHandler>();*/

        return services;
    }
}
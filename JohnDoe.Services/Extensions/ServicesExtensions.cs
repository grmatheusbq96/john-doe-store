using JohnDoe.Core.Interfaces.RabbitMq;
using JohnDoe.Services.Consumers;
using JohnDoe.Services.RabbitMq;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace JohnDoe.Services.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddJohnDoeServices(this IServiceCollection services)
    {
        services.AddScoped<IRabbitMqService, RabbitMqService>();
        services.AddMassTransit(x =>
        {
            x.AddDelayedMessageScheduler();
            x.SetKebabCaseEndpointNameFormatter();

            x.AddConsumer<UserConsumer>();

            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", "/", h =>
                {
                    h.Username("matheus");
                    h.Password("12345");
                });

                cfg.UseDelayedMessageScheduler();
                cfg.ConfigureEndpoints(context, new KebabCaseEndpointNameFormatter(false));
                cfg.UseMessageRetry(retry => { retry.Interval(3, TimeSpan.FromSeconds(5)); });
            });
        });

        return services;
    }
}
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace JohnDoe.Services.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddJohnDoeServices(this IServiceCollection services)
    {
        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", "/", h =>
                {
                    h.Username("matheus");
                    h.Password("12345");
                });

                cfg.ConfigureEndpoints(context);
            });
        });

        return services;
    }
}
using JohnDoe.Services.Extensions;

namespace JohnDoe.Api.Startup;

public static class DependencyInjectionConfiguration
{
    public static WebApplication ConfigureDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddJohnDoeServices();

        return builder.Build();
    }
}
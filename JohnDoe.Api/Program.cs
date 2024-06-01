using JohnDoe.Api.Startup;

namespace JohnDoe.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder
            .ConfigureDependencies()
            .ConfigureApp()
            .Run();
    }
}
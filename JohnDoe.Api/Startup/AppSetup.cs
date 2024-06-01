namespace JohnDoe.Api.Startup;

public static class AppSetup
{
    public static WebApplication ConfigureApp(this WebApplication app) 
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        return app;
    }
}

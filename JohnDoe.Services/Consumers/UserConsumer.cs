using JohnDoe.Core.Models;
using MassTransit;

namespace JohnDoe.Services.Consumers;

public class UserConsumer : IConsumer<UserModel>
{
    public async Task Consume(ConsumeContext<UserModel> context)
    {
        var usuario = context.Message;

        Console.WriteLine("Usuario encontrado na fila:");
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(usuario));

        await Task.Delay(TimeSpan.FromSeconds(2));
    }
}
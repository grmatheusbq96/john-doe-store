using JohnDoe.Core.Interfaces.RabbitMq;
using JohnDoe.Core.Models;
using MassTransit;

namespace JohnDoe.Services.RabbitMq;

public class RabbitMqService(IPublishEndpoint publishEndpoint) : IRabbitMqService
{
    private readonly IPublishEndpoint _publishEndpoint = publishEndpoint;

    public async Task AddUserToQueue(UserModel user)
    {
        await _publishEndpoint.Publish(user);
    }
}
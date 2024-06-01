using JohnDoe.Core.Models;

namespace JohnDoe.Core.Interfaces.RabbitMq;

public interface IRabbitMqService
{
    public Task AddUserToQueue(UserModel user);
}
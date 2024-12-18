using RabbitMQ.Client;
using System.Text.Json;
using System.Text;
using ApiRabbitMq.Domain.Interfaces;

namespace ApiRabbitMq.Infrastructure.Messaging
{
    public class RabbitMQProducer : IRabbitMQProducer
    {
        public async Task SendProductMessageAsync<T>(T message)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            
            using var connection =  await factory.CreateConnectionAsync();
            
            using var channel =  await connection.CreateChannelAsync();
            
            await channel.QueueDeclareAsync("product", exclusive: false);
            
            var json = JsonSerializer.Serialize(message);
            var body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(exchange: "", routingKey: "product", body: body);
        }
    }
}

namespace ApiRabbitMq.Domain.Interfaces

{
    public interface IRabbitMQProducer
    {
        Task SendProductMessageAsync<T>(T message);
    }
}

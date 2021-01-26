using RabbitMQ.Client;

namespace AspNetCore.SignalR.RabbitMQ
{
    public class RabbitMQOptions
    {
        public string ExchangeName { get; set; }
        public ConnectionFactory ConnectionFactory { get; set; }
    }
}

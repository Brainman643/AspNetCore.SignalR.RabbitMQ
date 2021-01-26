using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

namespace AspNetCore.SignalR.RabbitMQ
{
    public static class RabbitMQDependencyInjectionExtensions
    {
        public static ISignalRServerBuilder AddRabbitMQ(this ISignalRServerBuilder signalrBuilder)
        {
            signalrBuilder.Services.AddSingleton(typeof(HubLifetimeManager<>), typeof(RabbitMQHubLifetimeManager<>));
            return signalrBuilder;
        }
        public static ISignalRServerBuilder AddRabbitMQ(this ISignalRServerBuilder signalrBuilder, Action<RabbitMQOptions> configure)
        {
            signalrBuilder.Services.Configure(configure);
            signalrBuilder.Services.AddSingleton(typeof(HubLifetimeManager<>), typeof(RabbitMQHubLifetimeManager<>));
            return signalrBuilder;
        }
        public static ISignalRServerBuilder AddRabbitMQ(this ISignalRServerBuilder signalrBuilder, string rabbitMQConnectionString, string exchangeName)
        {
            return AddRabbitMQ(signalrBuilder, o =>
            {
                o.ConnectionFactory = new ConnectionFactory() { Uri = new Uri(rabbitMQConnectionString) };
                o.ExchangeName = exchangeName;
            });
        }
    }
}

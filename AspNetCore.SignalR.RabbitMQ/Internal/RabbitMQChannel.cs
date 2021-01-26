namespace AspNetCore.SignalR.RabbitMQ.Internal
{
    internal enum RabbitMQChannel
    {
        All,
        Group,
        Groups,
        Connection,
        Connections,
        User,
        Users,
        GroupCommand,
        Ack
    }
}

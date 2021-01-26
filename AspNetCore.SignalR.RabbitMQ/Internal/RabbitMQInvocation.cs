using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCore.SignalR.RabbitMQ.Internal
{
    public readonly struct RabbitMQInvocation
    {
        public IReadOnlyList<string> ExcludedConnectionIds { get; }
        public SerializedHubMessage Message { get; }
    
        public RabbitMQInvocation(SerializedHubMessage message, IReadOnlyList<string> excludedConnectionIds)
        {
            this.Message = message;
            this.ExcludedConnectionIds = excludedConnectionIds;
        }
    }
}

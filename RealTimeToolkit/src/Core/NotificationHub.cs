using System;
using System.Threading.Tasks;

#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
using Microsoft.AspNetCore.SignalR;
#endif

#if NET472_OR_GREATER || NET452
using Microsoft.AspNet.SignalR;
#endif

namespace RealTimeToolkit.Core
{
#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
    public class NotificationHub : Hub
    {
        private readonly SignalRConnectionManager _connectionManager;

        public NotificationHub(SignalRConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public override Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier ?? Context.ConnectionId;
            _connectionManager.AddConnection(userId, Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            _connectionManager.RemoveConnection(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
#else
    public class NotificationHub : Hub
    {
        private readonly SignalRConnectionManager _connectionManager = new();

        public override Task OnConnected()
        {
            var userId = Context.User.Identity?.Name ?? Context.ConnectionId;
            _connectionManager.AddConnection(userId, Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _connectionManager.RemoveConnection(Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
#endif
}

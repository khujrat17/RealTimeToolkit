using System.Threading.Tasks;

#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
using Microsoft.AspNetCore.SignalR;
#endif

#if NET472_OR_GREATER || NET452
using Microsoft.AspNet.SignalR;
#endif

namespace RealTimeToolkit.Core
{
    /// <summary>
    /// Unified API for broadcasting messages via SignalR.
    /// </summary>
    public class MessageBus
    {
#if NET8_0_OR_GREATER || NET7_0_OR_GREATER
        private readonly IHubContext<Hub> _hubContext;

        public MessageBus(IHubContext<Hub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task BroadcastAsync(string eventName, object message)
        {
            await _hubContext.Clients.All.SendAsync(eventName, message);
        }

        public async Task SendToUserAsync(string userId, string eventName, object message)
        {
            await _hubContext.Clients.User(userId).SendAsync(eventName, message);
        }

        public async Task SendToGroupAsync(string groupName, string eventName, object message)
        {
            await _hubContext.Clients.Group(groupName).SendAsync(eventName, message);
        }
#else
        private readonly IHubContext _hubContext;

        public MessageBus()
        {
            _hubContext = GlobalHost.ConnectionManager.GetHubContext("NotificationHub");
        }

        public void Broadcast(string eventName, object message)
        {
            _hubContext.Clients.All.Invoke(eventName, message);
        }

        public void SendToUser(string userId, string eventName, object message)
        {
            _hubContext.Clients.User(userId).Invoke(eventName, message);
        }

        public void SendToGroup(string groupName, string eventName, object message)
        {
            _hubContext.Clients.Group(groupName).Invoke(eventName, message);
        }
#endif
    }
}

using System.Collections.Concurrent;
using System.Collections.Generic;

namespace RealTimeToolkit.Core
{
    /// <summary>
    /// Thread-safe connection tracking for SignalR users.
    /// </summary>
    public class SignalRConnectionManager
    {
        private static readonly ConcurrentDictionary<string, string> _connections = new();

        public void AddConnection(string userId, string connectionId)
        {
            _connections[userId] = connectionId;
        }

        public void RemoveConnection(string connectionId)
        {
            foreach (var pair in _connections)
            {
                if (pair.Value == connectionId)
                {
                    _connections.TryRemove(pair.Key, out _);
                    break;
                }
            }
        }

        public string? GetConnectionId(string userId)
        {
            return _connections.TryGetValue(userId, out var connId) ? connId : null;
        }

        public IEnumerable<string> GetAllConnections() => _connections.Values;
    }
}

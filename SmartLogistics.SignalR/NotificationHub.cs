using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SmartLogistics.SignalR
{
    public class NotificationHub : Hub
    {
        public async Task RegisterUser(string userId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"User_{userId}");
        }

        public async Task UnregisterUser(string userId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"User_{userId}");
        }

        public async Task SendNotification(string userId, string title, string message)
        {
            await Clients.Group($"User_{userId}").SendAsync("ReceiveNotification", new
            {
                Id = Guid.NewGuid(),
                Title = title,
                Message = message,
                Timestamp = DateTime.UtcNow
            });
        }

        public async Task BroadcastSystemAlert(string message)
        {
            await Clients.All.SendAsync("ReceiveSystemAlert", new
            {
                Message = message,
                Timestamp = DateTime.UtcNow
            });
        }
    }
}

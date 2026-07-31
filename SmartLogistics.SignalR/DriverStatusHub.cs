using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SmartLogistics.SignalR
{
    public class DriverStatusHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("NotifyConnection", "Connected to Driver Monitor.");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            // Can log disconnect or update driver state to offline
            await base.OnDisconnectedAsync(exception);
        }

        public async Task UpdateDriverStatus(string driverId, string status)
        {
            // Broadcast driver status change (e.g. Online, Offline, OnTrip) to dispatcher clients
            await Clients.All.SendAsync("ReceiveDriverStatus", new
            {
                DriverId = driverId,
                Status = status,
                Timestamp = DateTime.UtcNow
            });
        }
    }
}

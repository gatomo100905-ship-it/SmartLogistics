using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SmartLogistics.SignalR
{
    public class TrackingHub : Hub
    {
        public async Task JoinTripGroup(string tripId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"Trip_{tripId}");
            await Clients.Caller.SendAsync("NotifyStatus", $"Successfully joined tracking for Trip {tripId}");
        }

        public async Task LeaveTripGroup(string tripId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"Trip_{tripId}");
            await Clients.Caller.SendAsync("NotifyStatus", $"Stopped tracking for Trip {tripId}");
        }

        public async Task SendLocationUpdate(string tripId, double latitude, double longitude, double speedKmh)
        {
            // Broadcast location update to all clients monitoring this trip (e.g., dispatchers, customers)
            await Clients.Group($"Trip_{tripId}").SendAsync("ReceiveLocation", new
            {
                TripId = tripId,
                Latitude = latitude,
                Longitude = longitude,
                SpeedKmh = speedKmh,
                Timestamp = System.DateTime.UtcNow
            });
        }
    }
}

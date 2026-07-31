using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface ITrackingService
    {
        Task<bool> UpdateGPSLocationAsync(Guid tripId, double lat, double lng, double speed);
        Task<object> GetTrackingHistoryAsync(Guid tripId);
    }

    public class TrackingService : ITrackingService
    {
        public async Task<bool> UpdateGPSLocationAsync(Guid tripId, double lat, double lng, double speed)
        {
            await Task.Delay(10);
            return true;
        }

        public async Task<object> GetTrackingHistoryAsync(Guid tripId)
        {
            await Task.Delay(50);
            return new { TripId = tripId, Lat = 10.8231, Lng = 106.6297, Speed = 55.5 };
        }
    }
}

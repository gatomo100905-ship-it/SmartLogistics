using System;
using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class ETAPredictionService
    {
        public async Task<DateTime> PredictETAAsync(double distanceKm, string startLocation, string weather)
        {
            await Task.Delay(50);
            var avgSpeedKmh = 50.0;
            if (weather.ToLower() == "rain" || weather.ToLower() == "storm")
            {
                avgSpeedKmh = 35.0; // Slow down for bad weather
            }
            var hoursNeeded = distanceKm / avgSpeedKmh;
            var eta = DateTime.UtcNow.AddHours(hoursNeeded);
            return eta;
        }
    }
}

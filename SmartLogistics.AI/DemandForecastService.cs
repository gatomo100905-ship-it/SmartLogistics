using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class DemandForecastService
    {
        public async Task<Dictionary<string, double>> ForecastDemandAsync(string category, int monthsAhead)
        {
            await Task.Delay(50); // Simulate model inference
            var forecast = new Dictionary<string, double>();
            var random = new Random();
            var baseVolume = 1200.0;

            for (int i = 1; i <= monthsAhead; i++)
            {
                var monthName = DateTime.UtcNow.AddMonths(i).ToString("MMMM");
                var trend = 1.05 + (random.NextDouble() * 0.1 - 0.05); // 5% growth trend +/- 5% noise
                baseVolume = Math.Round(baseVolume * trend, 2);
                forecast.Add(monthName, baseVolume);
            }
            return forecast;
        }
    }
}

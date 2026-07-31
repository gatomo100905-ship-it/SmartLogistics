using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IDashboardService
    {
        Task<object> GetManagerDashboardStatsAsync();
        Task<object> GetDriverDashboardStatsAsync(Guid driverId);
    }

    public class DashboardService : IDashboardService
    {
        public async Task<object> GetManagerDashboardStatsAsync()
        {
            await Task.Delay(50);
            return new { ActiveTrips = 15, RevenueToday = 120000000.00m, LowStockAlerts = 2 };
        }

        public async Task<object> GetDriverDashboardStatsAsync(Guid driverId)
        {
            await Task.Delay(50);
            return new { CompletedTrips = 8, ActiveTripNumber = "TR-881", HoursDriven = 4.5 };
        }
    }
}

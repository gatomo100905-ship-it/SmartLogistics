using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class CostPredictionService
    {
        public async Task<decimal> EstimateTripCostAsync(double distanceKm, double weightTons, string vehicleType, decimal currentFuelPrice)
        {
            await Task.Delay(40);
            var fuelConsumptionRate = 0.15; // liters per km
            if (vehicleType.ToLower() == "heavy truck" || vehicleType.ToLower() == "container")
            {
                fuelConsumptionRate = 0.35;
            }

            var fuelCost = (decimal)(distanceKm * fuelConsumptionRate) * currentFuelPrice;
            var driverCost = (decimal)(distanceKm * 2000.0); // 2000 VND per km
            var tollFees = 150000.00m; // fixed mock toll

            return fuelCost + driverCost + tollFees;
        }
    }
}

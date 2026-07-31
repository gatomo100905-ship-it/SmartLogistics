using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IVehicleService
    {
        Task<bool> RegisterVehicleAsync(string plate, string brand, string model, int typeId);
        Task<bool> LogMaintenanceAsync(Guid vehicleId, double cost, string desc);
    }

    public class VehicleService : IVehicleService
    {
        public async Task<bool> RegisterVehicleAsync(string plate, string brand, string model, int typeId)
        {
            await Task.Delay(50);
            return true;
        }

        public async Task<bool> LogMaintenanceAsync(Guid vehicleId, double cost, string desc)
        {
            await Task.Delay(50);
            return true;
        }
    }
}

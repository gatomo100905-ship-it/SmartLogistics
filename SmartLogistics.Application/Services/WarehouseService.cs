using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IWarehouseService
    {
        Task<object> GetWarehouseCapacityAsync(int warehouseId);
        Task<bool> TransferStockAsync(int fromWarehouseId, int toWarehouseId, string sku, int qty);
    }

    public class WarehouseService : IWarehouseService
    {
        public async Task<object> GetWarehouseCapacityAsync(int warehouseId)
        {
            await Task.Delay(50);
            return new { TotalCapacity = 10000.0, OccupiedSpace = 7500.0, FilledPercentage = 75.0 };
        }

        public async Task<bool> TransferStockAsync(int fromWarehouseId, int toWarehouseId, string sku, int qty)
        {
            await Task.Delay(50);
            return true;
        }
    }
}

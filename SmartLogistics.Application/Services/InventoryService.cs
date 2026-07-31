using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IInventoryService
    {
        Task<int> GetStockLevelAsync(string productSku, int warehouseId);
        Task<bool> AdjustStockAsync(string productSku, int warehouseId, int quantity, string reason);
    }

    public class InventoryService : IInventoryService
    {
        public async Task<int> GetStockLevelAsync(string productSku, int warehouseId)
        {
            await Task.Delay(50);
            return 1200; // Mock stock count
        }

        public async Task<bool> AdjustStockAsync(string productSku, int warehouseId, int quantity, string reason)
        {
            await Task.Delay(50);
            return true;
        }
    }
}

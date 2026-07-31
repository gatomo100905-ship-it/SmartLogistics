using SmartLogistics.Domain.Entities.Warehouse;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IInventoryRepository : IGenericRepository<Inventory>
    {
        Task<Inventory> GetStockBySkuAsync(string sku, int binId);
    }
}

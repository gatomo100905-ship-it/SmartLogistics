using Microsoft.EntityFrameworkCore;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.Warehouse;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Inventory> GetStockBySkuAsync(string sku, int binId)
        {
            return await _dbSet.FirstOrDefaultAsync(i => i.ProductSku == sku && i.BinLocationId == binId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.Warehouse;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class WarehouseRepository : GenericRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Warehouse> GetWarehouseWithZonesAsync(int id)
        {
            return await _context.Warehouses
                .Include(w => w.Zones)
                .FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}

using SmartLogistics.Domain.Entities.Warehouse;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IWarehouseRepository : IGenericRepository<Warehouse>
    {
        Task<Warehouse> GetWarehouseWithZonesAsync(int id);
    }
}

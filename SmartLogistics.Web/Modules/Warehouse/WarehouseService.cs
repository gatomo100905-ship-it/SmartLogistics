using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Warehouse
{
    public interface IWarehouseService
    {
        // Interface declaration placeholder
    }

    public class WarehouseService : IWarehouseService
    {
        public object GetWarehouseCapacity(int id) { return new { Id = id, Name = "North Warehouse", Capacity = 5000, Occupied = 3800 }; }
    }
}

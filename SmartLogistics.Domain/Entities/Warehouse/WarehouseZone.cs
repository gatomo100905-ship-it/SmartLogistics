using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class WarehouseZone
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } // e.g. "ZONE-A", "ZONE-COOL"
        public double? TemperatureRequired { get; set; } // Nullable, in Celsius
        public virtual ICollection<Shelf> Shelves { get; set; } = new List<Shelf>();
    }
}

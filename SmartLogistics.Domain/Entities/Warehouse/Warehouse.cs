using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double CapacityVolume { get; set; } // in cubic meters
        public double CapacityWeight { get; set; } // in tons
        public bool IsActive { get; set; } = true;
        public virtual ICollection<WarehouseZone> Zones { get; set; } = new List<WarehouseZone>();
    }
}

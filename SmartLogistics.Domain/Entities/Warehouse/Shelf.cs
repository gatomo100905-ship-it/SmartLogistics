using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class Shelf
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public virtual WarehouseZone Zone { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } // e.g. "SHELF-A1"
        public int LevelsCount { get; set; }
        public virtual ICollection<BinLocation> BinLocations { get; set; } = new List<BinLocation>();
    }
}

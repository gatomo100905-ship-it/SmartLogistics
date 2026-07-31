using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class BinLocation
    {
        public int Id { get; set; }
        public int ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } // e.g. "BIN-A1-03"
        public int Row { get; set; }
        public int Level { get; set; }
        public double MaxWeight { get; set; } // in kilograms
        public bool IsOccupied { get; set; } = false;
        public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
    }
}

using System;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class Inventory
    {
        public long Id { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public int BinLocationId { get; set; }
        public virtual BinLocation BinLocation { get; set; }
        public int Quantity { get; set; }
        public string BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}

using System;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class StockAdjustment
    {
        public Guid Id { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public string ProductSku { get; set; }
        public int QuantityAdjusted { get; set; } // positive or negative
        public string Reason { get; set; } // e.g. "Damaged", "Audit Correction"
        public Guid ApprovedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

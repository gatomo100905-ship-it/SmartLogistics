using System;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class Transfer
    {
        public Guid Id { get; set; }
        public int FromWarehouseId { get; set; }
        public virtual Warehouse FromWarehouse { get; set; }
        public int ToWarehouseId { get; set; }
        public virtual Warehouse ToWarehouse { get; set; }
        public string ProductSku { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } // e.g. "Requested", "InTransit", "Completed", "Cancelled"
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

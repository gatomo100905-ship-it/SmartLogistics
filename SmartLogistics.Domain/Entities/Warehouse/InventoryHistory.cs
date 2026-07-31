using System;

namespace SmartLogistics.Domain.Entities.Warehouse
{
    public class InventoryHistory
    {
        public long Id { get; set; }
        public string ProductSku { get; set; }
        public int BinLocationId { get; set; }
        public string TransactionType { get; set; } // e.g. "StockIn", "StockOut", "Transfer"
        public int QuantityChanged { get; set; }
        public string ReferenceNumber { get; set; } // e.g. Order ID, Goods Receipt ID
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}

using System;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class Revenue
    {
        public Guid Id { get; set; }
        public string Source { get; set; } // e.g. "ShippingService", "WarehouseStorage"
        public decimal Amount { get; set; }
        public DateTime RevenueDate { get; set; }
        public string Description { get; set; }
        public Guid? ReferenceId { get; set; } // Links to InvoiceId
    }
}

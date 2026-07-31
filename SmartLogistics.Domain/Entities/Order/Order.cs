using System;
using System.Collections.Generic;
using SmartLogistics.Domain.Entities.CRM;

namespace SmartLogistics.Domain.Entities.Order
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } // e.g. "Pending", "Processing", "Completed", "Cancelled"
        public decimal TotalAmount { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

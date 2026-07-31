using System;

namespace SmartLogistics.Domain.Entities.Order
{
    public class DeliveryHistory
    {
        public Guid Id { get; set; }
        public Guid DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}

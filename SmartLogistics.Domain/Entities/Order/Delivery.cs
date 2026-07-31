using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Order
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public Guid ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
        public Guid? TripId { get; set; } // Linked to Fleet Trip
        public string Status { get; set; } // e.g. "Assigned", "InTransit", "Delivered", "Failed"
        public string RecipientName { get; set; }
        public string RecipientPhone { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public virtual ICollection<DeliveryHistory> History { get; set; } = new List<DeliveryHistory>();
    }
}

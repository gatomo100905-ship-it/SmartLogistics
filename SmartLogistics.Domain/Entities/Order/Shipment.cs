using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Order
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public string ShipmentNumber { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public string OriginAddress { get; set; }
        public string DestinationAddress { get; set; }
        public double Weight { get; set; } // in kg
        public double Volume { get; set; } // in m3
        public string Status { get; set; } // e.g. "Pending", "Shipped", "Delivered", "Returned"
        public DateTime? EstimatedDelivery { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; } = new List<ShipmentItem>();
    }
}

using System;

namespace SmartLogistics.Domain.Entities.Order
{
    public class ShipmentItem
    {
        public Guid Id { get; set; }
        public Guid ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double WeightKg { get; set; }
    }
}

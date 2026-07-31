using System;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class Fuel
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime RefuelDate { get; set; }
        public double OdometerReading { get; set; }
        public double Liters { get; set; }
        public decimal PricePerLiter { get; set; }
        public decimal TotalCost { get; set; }
        public string ReceiptImageUrl { get; set; }
        public string Location { get; set; }
    }
}

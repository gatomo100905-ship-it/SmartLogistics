using System;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingYear { get; set; }
        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public string Status { get; set; } // e.g. "Available", "InTransit", "Maintenance"
        public double FuelCapacity { get; set; } // in liters
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

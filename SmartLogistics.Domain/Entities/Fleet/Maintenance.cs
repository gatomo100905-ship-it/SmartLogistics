using System;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class Maintenance
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double OdometerReading { get; set; }
        public string Type { get; set; } // e.g. "Routine", "Repair", "Inspection"
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string ServiceCenter { get; set; }
    }
}

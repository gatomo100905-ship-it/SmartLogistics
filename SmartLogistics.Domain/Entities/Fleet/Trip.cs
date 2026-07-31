using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class Trip
    {
        public Guid Id { get; set; }
        public string TripNumber { get; set; }
        public Guid VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public Guid DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string Status { get; set; } // e.g. "Scheduled", "InProgress", "Completed", "Cancelled"
        public double EstimatedDistanceKm { get; set; }
        public double? ActualDistanceKm { get; set; }
        public virtual ICollection<GPSLocation> RouteHistory { get; set; } = new List<GPSLocation>();
    }
}

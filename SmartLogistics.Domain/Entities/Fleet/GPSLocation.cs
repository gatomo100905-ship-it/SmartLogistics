using System;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class GPSLocation
    {
        public long Id { get; set; }
        public Guid TripId { get; set; }
        public virtual Trip Trip { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double SpeedKmh { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}

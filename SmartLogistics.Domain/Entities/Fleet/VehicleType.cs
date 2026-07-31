namespace SmartLogistics.Domain.Entities.Fleet
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g. "Heavy Truck", "Van", "Container"
        public string Description { get; set; }
        public double MaxPayloadTons { get; set; }
        public double MaxVolumeCubicMeters { get; set; }
    }
}

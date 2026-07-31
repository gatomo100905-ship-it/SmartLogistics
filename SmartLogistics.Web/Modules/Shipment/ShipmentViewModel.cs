namespace SmartLogistics.Web.Modules.Shipment
{
    public class ShipmentViewModel
    {
        public int ShipmentId { get; set; }
        public string TrackingNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }
        public string DriverName { get; set; }
    }
}

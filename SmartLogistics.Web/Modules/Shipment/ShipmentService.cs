using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Shipment
{
    public interface IShipmentService
    {
        // Interface declaration placeholder
    }

    public class ShipmentService : IShipmentService
    {
        public object GetTrackingInfo(string trackingNum) { return new { TrackingNumber = trackingNum, Status = "In Transit", Lat = 10.8231, Lng = 106.6297 }; }
    }
}

using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Vehicle
{
    public interface IVehicleService
    {
        // Interface declaration placeholder
    }

    public class VehicleService : IVehicleService
    {
        public object GetAvailableVehicles() { return new List<object> { new { Id = 1, Plate = "29A-12345", Type = "Heavy Truck" } }; }
    }
}

using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Orders
{
    public interface IOrdersService
    {
        // Interface declaration placeholder
    }

    public class OrdersService : IOrdersService
    {
        public object GetOrderDetails(int id) { return new { Id = id, Number = "ORD-9921", Customer = "Beta Group", Status = "Processing" }; }
    }
}

using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Purchase
{
    public interface IPurchaseService
    {
        // Interface declaration placeholder
    }

    public class PurchaseService : IPurchaseService
    {
        public object GetPurchaseOrders() { return new List<object> { new { Id = 1, Supplier = "Hanoi Steel", Cost = 15000.00m } }; }
    }
}

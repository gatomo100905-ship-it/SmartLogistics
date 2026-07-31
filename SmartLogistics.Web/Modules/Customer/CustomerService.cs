using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Customer
{
    public interface ICustomerService
    {
        // Interface declaration placeholder
    }

    public class CustomerService : ICustomerService
    {
        public IEnumerable<object> GetActiveCustomers() { return new List<object> { new { Id = 1, Name = "Alpha Corp", Email = "info@alphacorp.com" } }; }
    }
}

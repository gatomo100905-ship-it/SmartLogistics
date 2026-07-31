using SmartLogistics.Domain.Entities.CRM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetActiveCustomersAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.CRM;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Customer>> GetActiveCustomersAsync()
        {
            return await _dbSet.Where(c => c.IsActive).ToListAsync();
        }
    }
}

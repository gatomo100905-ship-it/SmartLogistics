using Microsoft.EntityFrameworkCore;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.Finance;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class FinanceRepository : GenericRepository<Invoice>, IFinanceRepository
    {
        public FinanceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<decimal> GetTotalUnpaidAmountAsync()
        {
            return await _dbSet
                .Where(i => i.Status != "Paid" && i.Status != "Cancelled")
                .SumAsync(i => i.TotalAmount);
        }
    }
}

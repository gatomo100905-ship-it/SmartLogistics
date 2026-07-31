using SmartLogistics.Domain.Entities.Finance;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IFinanceRepository : IGenericRepository<Invoice>
    {
        Task<decimal> GetTotalUnpaidAmountAsync();
    }
}

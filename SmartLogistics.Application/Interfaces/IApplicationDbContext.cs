using Microsoft.EntityFrameworkCore;
using SmartLogistics.Domain.Entities.Order;
using System.Threading;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

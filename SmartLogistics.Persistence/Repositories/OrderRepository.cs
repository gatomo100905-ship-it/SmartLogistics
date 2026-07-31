using Microsoft.EntityFrameworkCore;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.Order;
using System;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Order> GetOrderWithItemsAsync(Guid id)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}

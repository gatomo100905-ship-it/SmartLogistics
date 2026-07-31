using SmartLogistics.Domain.Entities.Order;
using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order> GetOrderWithItemsAsync(Guid id);
    }
}

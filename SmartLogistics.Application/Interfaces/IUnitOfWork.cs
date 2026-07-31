using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IWarehouseRepository Warehouses { get; }
        IInventoryRepository Inventories { get; }
        IOrderRepository Orders { get; }
        IFinanceRepository Finance { get; }
        Task<int> CompleteAsync();
    }
}

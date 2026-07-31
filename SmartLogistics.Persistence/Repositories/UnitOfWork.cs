using SmartLogistics.Application.Interfaces;
using System.Threading.Tasks;

namespace SmartLogistics.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICustomerRepository Customers { get; }
        public IWarehouseRepository Warehouses { get; }
        public IInventoryRepository Inventories { get; }
        public IOrderRepository Orders { get; }
        public IFinanceRepository Finance { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Customers = new CustomerRepository(context);
            Warehouses = new WarehouseRepository(context);
            Inventories = new InventoryRepository(context);
            Orders = new OrderRepository(context);
            Finance = new FinanceRepository(context);
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}

using Microsoft.EntityFrameworkCore;
using SmartLogistics.Domain.Entities.Identity;
using SmartLogistics.Domain.Entities.Warehouse;
using SmartLogistics.Domain.Entities.Order;
using SmartLogistics.Domain.Entities.Fleet;
using SmartLogistics.Domain.Entities.Finance;
using SmartLogistics.Domain.Entities.HR;
using SmartLogistics.Domain.Entities.CRM;

namespace SmartLogistics.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ================= IDENTITY TABLES =================
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionGroup> PermissionGroups { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        // ================= WAREHOUSE TABLES =================
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseZone> Zones { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<BinLocation> Bins { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryHistory> InventoryHistories { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<StockAdjustment> StockAdjustments { get; set; }

        // ================= ORDER TABLES =================
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryHistory> DeliveryHistories { get; set; }

        // ================= VEHICLE / FLEET TABLES =================
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<GPSLocation> GPSLocations { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }

        // ================= FINANCE TABLES =================
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }

        // ================= HR TABLES =================
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        // ================= CRM TABLES =================
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Apply configurations if needed
            // For example:
            // modelBuilder.Entity<Order>().HasIndex(o => o.OrderNumber).IsUnique();
        }
    }
}

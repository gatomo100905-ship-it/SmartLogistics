using System;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Category { get; set; } // e.g. "Fuel", "Maintenance", "Salary", "Rent"
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Description { get; set; }
        public Guid? ApprovedBy { get; set; }
        public Guid? ReferenceId { get; set; } // e.g. FuelId or MaintenanceId for auto expense tracking
    }
}

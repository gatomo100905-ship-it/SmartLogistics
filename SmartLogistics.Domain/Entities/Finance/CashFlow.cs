using System;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class CashFlow
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; } // Positive for inflow, Negative for outflow
        public string Type { get; set; } // e.g. "Inflow", "Outflow"
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal BalanceAfterTransaction { get; set; }
    }
}

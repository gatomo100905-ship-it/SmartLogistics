using System;

namespace SmartLogistics.Domain.Entities.HR
{
    public class Payroll
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; } // Base + Allowances - Deductions
        public DateTime? PaymentDate { get; set; }
        public string Status { get; set; } // e.g. "Draft", "Approved", "Paid"
    }
}

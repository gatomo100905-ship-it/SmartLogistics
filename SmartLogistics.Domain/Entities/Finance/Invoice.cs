using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid ReferenceId { get; set; } // e.g. CustomerId or OrderId
        public string ReferenceType { get; set; } // e.g. "Order", "Contract"
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal AmountExcludingTax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // e.g. "Draft", "Issued", "Paid", "Overdue", "Cancelled"
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}

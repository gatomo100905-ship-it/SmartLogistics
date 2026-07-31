using System;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // e.g. "BankTransfer", "Cash", "CreditCard"
        public string TransactionReference { get; set; }
        public string Status { get; set; } // e.g. "Pending", "Completed", "Failed"
    }
}

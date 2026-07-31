namespace SmartLogistics.Web.Modules.Accounting
{
    public class AccountingViewModel
    {
        public string InvoiceNumber { get; set; }
        public string ClientName { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime DueDate { get; set; }
        public string PaymentStatus { get; set; }
    }
}

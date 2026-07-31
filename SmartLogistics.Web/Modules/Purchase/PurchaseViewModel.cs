namespace SmartLogistics.Web.Modules.Purchase
{
    public class PurchaseViewModel
    {
        public int PurchaseOrderId { get; set; }
        public string SupplierName { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; }
    }
}

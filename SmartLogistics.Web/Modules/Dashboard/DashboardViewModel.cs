namespace SmartLogistics.Web.Modules.Dashboard
{
    public class DashboardViewModel
    {
        public int TotalShipments { get; set; }
        public int PendingOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public double DeliveriesOnTimePercentage { get; set; }
    }
}

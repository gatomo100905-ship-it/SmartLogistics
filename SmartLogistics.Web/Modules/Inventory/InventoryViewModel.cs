namespace SmartLogistics.Web.Modules.Inventory
{
    public class InventoryViewModel
    {
        public int ItemId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public int QuantityOnHand { get; set; }
        public int ReorderPoint { get; set; }
        public string LocationInWarehouse { get; set; }
    }
}

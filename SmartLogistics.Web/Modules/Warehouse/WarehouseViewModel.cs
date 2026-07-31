namespace SmartLogistics.Web.Modules.Warehouse
{
    public class WarehouseViewModel
    {
        public int WarehouseId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int CapacitySquareMeters { get; set; }
        public int OccupiedSpaceSquareMeters { get; set; }
    }
}

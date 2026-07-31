namespace SmartLogistics.Domain.Constants
{
    public static class Permissions
    {
        public static class Warehouse
        {
            public const string View = "Permissions.Warehouse.View";
            public const string Create = "Permissions.Warehouse.Create";
            public const string Edit = "Permissions.Warehouse.Edit";
            public const string Delete = "Permissions.Warehouse.Delete";
            public const string AdjustStock = "Permissions.Warehouse.AdjustStock";
        }

        public static class Orders
        {
            public const string View = "Permissions.Orders.View";
            public const string Create = "Permissions.Orders.Create";
            public const string Edit = "Permissions.Orders.Edit";
            public const string Cancel = "Permissions.Orders.Cancel";
        }

        public static class Fleet
        {
            public const string View = "Permissions.Fleet.View";
            public const string ManageVehicles = "Permissions.Fleet.ManageVehicles";
            public const string AssignDriver = "Permissions.Fleet.AssignDriver";
            public const string TrackGPS = "Permissions.Fleet.TrackGPS";
        }

        public static class Finance
        {
            public const string View = "Permissions.Finance.View";
            public const string ApproveExpense = "Permissions.Finance.ApproveExpense";
            public const string ExportInvoices = "Permissions.Finance.ExportInvoices";
        }
    }
}

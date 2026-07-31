namespace SmartLogistics.Domain.Constants
{
    public static class Roles
    {
        public const string SuperAdmin = "Super Admin";
        public const string CEO = "CEO";
        public const string LogisticsManager = "Logistics Manager";
        public const string WarehouseManager = "Warehouse Manager";
        public const string Dispatcher = "Dispatcher";
        public const string Driver = "Driver";
        public const string WarehouseStaff = "Warehouse Staff";
        public const string Accountant = "Accountant";
        public const string HR = "HR";
        public const string Customer = "Customer";
        public const string Support = "Support";
        public const string Auditor = "Auditor";

        public static readonly string[] All = new[]
        {
            SuperAdmin,
            CEO,
            LogisticsManager,
            WarehouseManager,
            Dispatcher,
            Driver,
            WarehouseStaff,
            Accountant,
            HR,
            Customer,
            Support,
            Auditor
        };

        public static readonly System.Collections.Generic.Dictionary<string, System.Guid> RoleIds = new()
        {
            { SuperAdmin, System.Guid.Parse("11111111-1111-1111-1111-111111111111") },
            { CEO, System.Guid.Parse("22222222-2222-2222-2222-222222222222") },
            { LogisticsManager, System.Guid.Parse("33333333-3333-3333-3333-333333333333") },
            { WarehouseManager, System.Guid.Parse("44444444-4444-4444-4444-444444444444") },
            { Dispatcher, System.Guid.Parse("55555555-5555-5555-5555-555555555555") },
            { Driver, System.Guid.Parse("66666666-6666-6666-6666-666666666666") },
            { WarehouseStaff, System.Guid.Parse("77777777-7777-7777-7777-777777777777") },
            { Accountant, System.Guid.Parse("88888888-8888-8888-8888-888888888888") },
            { HR, System.Guid.Parse("99999999-9999-9999-9999-999999999999") },
            { Customer, System.Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
            { Support, System.Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
            { Auditor, System.Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc") }
        };
    }
}

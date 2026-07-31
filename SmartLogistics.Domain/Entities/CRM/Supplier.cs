using System;

namespace SmartLogistics.Domain.Entities.CRM
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string Status { get; set; } // e.g. "Active", "Inactive"
        public string SupplyType { get; set; } // e.g. "Packaging", "Fuel", "FleetMaintenance"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

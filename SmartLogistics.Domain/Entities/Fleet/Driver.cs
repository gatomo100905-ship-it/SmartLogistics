using System;

namespace SmartLogistics.Domain.Entities.Fleet
{
    public class Driver
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; } // Links to Identity ApplicationUser
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseClass { get; set; } // e.g. "C", "FC"
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; } // e.g. "Available", "OnTrip", "OffDuty"
        public DateTime HireDate { get; set; }
    }
}

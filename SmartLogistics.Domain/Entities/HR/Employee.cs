using System;

namespace SmartLogistics.Domain.Entities.HR
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; } // Link to Identity ApplicationUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}".Trim();
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; } // e.g. "HR", "Accounting", "Logistics", "IT"
        public string Position { get; set; } // e.g. "Manager", "Accountant", "Staff"
        public decimal BaseSalary { get; set; }
        public DateTime HireDate { get; set; }
        public string Status { get; set; } // e.g. "Active", "OnLeave", "Suspended", "Terminated"
    }
}

using System;

namespace SmartLogistics.Domain.Entities.HR
{
    public class Leave
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string LeaveType { get; set; } // e.g. "Sick", "Annual", "Maternity"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; } // e.g. "Pending", "Approved", "Rejected"
        public Guid? ApprovedBy { get; set; }
    }
}

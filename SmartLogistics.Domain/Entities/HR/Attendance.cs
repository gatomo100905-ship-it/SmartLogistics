using System;

namespace SmartLogistics.Domain.Entities.HR
{
    public class Attendance
    {
        public long Id { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string Status { get; set; } // e.g. "Present", "Absent", "Late", "OnLeave"
        public string Notes { get; set; }
    }
}

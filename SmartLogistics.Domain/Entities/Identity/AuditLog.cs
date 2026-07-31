using System;

namespace SmartLogistics.Domain.Entities.Identity
{
    public class AuditLog
    {
        public long Id { get; set; }
        public Guid? UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Action { get; set; } // e.g. "Create", "Update", "Delete"
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public string OldValues { get; set; } // JSON format
        public string NewValues { get; set; } // JSON format
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string IpAddress { get; set; }
    }
}

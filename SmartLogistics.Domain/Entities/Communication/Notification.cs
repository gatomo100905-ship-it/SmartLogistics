using System;

namespace SmartLogistics.Domain.Entities.Communication
{
    public class Notification
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Target user receiving notification
        public string Title { get; set; }
        public string Message { get; set; }
        public string LinkUrl { get; set; } // Redirect link when clicked
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

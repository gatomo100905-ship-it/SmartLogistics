using System;

namespace SmartLogistics.Domain.Entities.Communication
{
    public class ChatMessage
    {
        public long Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid? ReceiverId { get; set; } // Null for public or group chat channel
        public string GroupId { get; set; } // Null for direct messages
        public string MessageContent { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
        public string AttachmentUrl { get; set; }
    }
}

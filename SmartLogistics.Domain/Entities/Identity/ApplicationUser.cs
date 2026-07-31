using System;

namespace SmartLogistics.Domain.Entities.Identity
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid RoleId { get; set; }
        public virtual ApplicationRole Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
    }
}

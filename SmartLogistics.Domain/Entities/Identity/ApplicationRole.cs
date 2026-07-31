using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Identity
{
    public class ApplicationRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSystemRole { get; set; } = false;
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}

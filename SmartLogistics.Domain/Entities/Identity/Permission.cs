using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.Identity
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } // e.g. "USERS_VIEW", "ORDERS_CREATE"
        public string Description { get; set; }
        public int PermissionGroupId { get; set; }
        public virtual PermissionGroup Group { get; set; }
        public virtual ICollection<ApplicationRole> Roles { get; set; } = new List<ApplicationRole>();
    }
}

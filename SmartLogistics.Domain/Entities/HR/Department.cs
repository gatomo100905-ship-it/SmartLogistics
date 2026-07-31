using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.HR
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } // e.g. "IT", "HR", "LOG"
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}

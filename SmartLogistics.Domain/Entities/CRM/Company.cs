using System;
using System.Collections.Generic;

namespace SmartLogistics.Domain.Entities.CRM
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TaxCode { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}

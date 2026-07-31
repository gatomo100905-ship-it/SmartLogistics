using System;

namespace SmartLogistics.Domain.Entities.Finance
{
    public class Budget
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public int Year { get; set; }
        public decimal AllocatedAmount { get; set; }
        public decimal SpentAmount { get; set; }
        public decimal RemainingAmount => AllocatedAmount - SpentAmount;
    }
}

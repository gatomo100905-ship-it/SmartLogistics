using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Employees
{
    public interface IEmployeesService
    {
        // Interface declaration placeholder
    }

    public class EmployeesService : IEmployeesService
    {
        public object GetEmployeeProfile(int id) { return new { Id = id, Name = "Nguyen Van A", Dept = "Logistics Operations" }; }
    }
}

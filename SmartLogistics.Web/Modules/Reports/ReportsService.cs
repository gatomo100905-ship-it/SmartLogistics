using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Reports
{
    public interface IReportsService
    {
        // Interface declaration placeholder
    }

    public class ReportsService : IReportsService
    {
        public string ExportToPdf(string reportType) { return "/reports/export_" + System.Guid.NewGuid().ToString() + ".pdf"; }
    }
}

using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IReportService
    {
        Task<string> GenerateReportPdfAsync(string reportType, object criteria);
    }

    public class ReportService : IReportService
    {
        public async Task<string> GenerateReportPdfAsync(string reportType, object criteria)
        {
            await Task.Delay(100);
            return "/reports/pdf/" + reportType + "_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";
        }
    }
}

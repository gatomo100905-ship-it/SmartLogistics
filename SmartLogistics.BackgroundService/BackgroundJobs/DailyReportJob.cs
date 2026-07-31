using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class DailyReportJob
    {
        private readonly ILogger<DailyReportJob> _logger;

        public DailyReportJob(ILogger<DailyReportJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("DailyReportJob: Báº¯t Ä‘áº§u tá»•ng há»£p bĂ¡o cĂ¡o váº­n hĂ nh cuá»‘i ngĂ y lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p tá»•ng há»£p sá»‘ liá»‡u Ä‘Æ¡n hĂ ng vĂ  doanh thu trong ngĂ y
            await Task.Delay(1000); 

            _logger.LogInformation("DailyReportJob: Káº¿t xuáº¥t bĂ¡o cĂ¡o hoĂ n táº¥t. ÄĂ£ lÆ°u file DailyReport_{date}.pdf", DateTime.UtcNow.ToString("yyyyMMdd"));
        }
    }
}

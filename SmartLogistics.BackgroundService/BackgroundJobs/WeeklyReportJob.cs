using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class WeeklyReportJob
    {
        private readonly ILogger<WeeklyReportJob> _logger;

        public WeeklyReportJob(ILogger<WeeklyReportJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("WeeklyReportJob: Báº¯t Ä‘áº§u tĂ­nh toĂ¡n hiá»‡u suáº¥t tuáº§n lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p tá»•ng há»£p KPI tĂ i xáº¿, tá»· lá»‡ giao hĂ ng Ä‘Ăºng giá» (On-Time Delivery Rate)
            await Task.Delay(2000);

            _logger.LogInformation("WeeklyReportJob: HoĂ n táº¥t bĂ¡o cĂ¡o tuáº§n. ÄĂ£ gá»­i email tá»•ng há»£p cho Ban giĂ¡m Ä‘á»‘c.");
        }
    }
}

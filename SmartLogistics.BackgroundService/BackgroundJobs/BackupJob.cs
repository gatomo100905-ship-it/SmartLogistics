using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class BackupJob
    {
        private readonly ILogger<BackupJob> _logger;

        public BackupJob(ILogger<BackupJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("BackupJob: Báº¯t Ä‘áº§u sao lÆ°u Ä‘á»‹nh ká»³ cÆ¡ sá»Ÿ dá»¯ liá»‡u há»‡ thá»‘ng lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p nĂ©n DB SQL Server vĂ  Ä‘áº©y báº£n backup lĂªn lÆ°u trá»¯ Ä‘Ă¡m mĂ¢y an toĂ n
            await Task.Delay(3000);

            _logger.LogInformation("BackupJob: Backup thĂ nh cĂ´ng. ÄĂ£ lÆ°u trá»¯ file SmartLogistics_Backup_{date}.bak.", DateTime.UtcNow.ToString("yyyyMMdd_HHmmss"));
        }
    }
}

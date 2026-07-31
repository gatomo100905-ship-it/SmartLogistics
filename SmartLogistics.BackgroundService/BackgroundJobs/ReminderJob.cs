using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class ReminderJob
    {
        private readonly ILogger<ReminderJob> _logger;

        public ReminderJob(ILogger<ReminderJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("ReminderJob: QuĂ©t danh sĂ¡ch hĂ³a Ä‘Æ¡n quĂ¡ háº¡n vĂ  lá»‹ch báº£o trĂ¬ xe lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p tĂ¬m kiáº¿m cĂ´ng ná»£ chÆ°a tráº£ vĂ  xe sáº¯p Ä‘áº¿n má»‘c thay dáº§u báº£o dÆ°á»¡ng
            await Task.Delay(800);

            _logger.LogInformation("ReminderJob: ÄĂ£ gá»­i 5 nháº¯c nhá»Ÿ cĂ´ng ná»£ khĂ¡ch hĂ ng vĂ  2 lá»‹ch cáº£nh bĂ¡o báº£o trĂ¬ phÆ°Æ¡ng tiá»‡n.");
        }
    }
}

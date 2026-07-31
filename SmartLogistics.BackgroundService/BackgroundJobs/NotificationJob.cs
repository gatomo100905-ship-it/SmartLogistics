using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class NotificationJob
    {
        private readonly ILogger<NotificationJob> _logger;

        public NotificationJob(ILogger<NotificationJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("NotificationJob: Xá»­ lĂ½ hĂ ng Ä‘á»£i tin nháº¯n/thĂ´ng bĂ¡o há»‡ thá»‘ng lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p gá»­i SMS/Firebase push notification hĂ ng loáº¡t
            await Task.Delay(500);

            _logger.LogInformation("NotificationJob: Giáº£i phĂ³ng hĂ ng Ä‘á»£i thĂ´ng bĂ¡o thĂ nh cĂ´ng.");
        }
    }
}

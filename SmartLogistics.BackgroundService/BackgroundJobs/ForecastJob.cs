using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.BackgroundService.BackgroundJobs
{
    public class ForecastJob
    {
        private readonly ILogger<ForecastJob> _logger;

        public ForecastJob(ILogger<ForecastJob> logger)
        {
            _logger = logger;
        }

        public async Task RunAsync()
        {
            _logger.LogInformation("ForecastJob: Báº¯t Ä‘áº§u cháº¡y mĂ´ hĂ¬nh AI dá»± bĂ¡o nhu cáº§u kho váº­n lĂºc {time}...", DateTime.UtcNow);
            
            // Giáº£ láº­p náº¡p dá»¯ liá»‡u lá»‹ch sá»­ vĂ o mĂ´ hĂ¬nh dá»± Ä‘oĂ¡n tá»“n kho cáº§n nháº­p
            await Task.Delay(1500);

            _logger.LogInformation("ForecastJob: Dá»± bĂ¡o thĂ nh cĂ´ng. ÄĂ£ cáº­p nháº­t báº£ng sá»‘ liá»‡u dá»± Ä‘oĂ¡n nhu cáº§u váº­t tÆ° tuáº§n tá»›i.");
        }
    }
}

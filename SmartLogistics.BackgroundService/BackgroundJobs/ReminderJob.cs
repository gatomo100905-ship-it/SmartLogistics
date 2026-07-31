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
            _logger.LogInformation("ReminderJob: Quét danh sách hóa đơn quá hạn và lịch bảo trì xe lúc {time}...", DateTime.UtcNow);
            
            // Giả lập tìm kiếm công nợ chưa trả và xe sắp đến mốc thay dầu bảo dưỡng
            await Task.Delay(800);

            _logger.LogInformation("ReminderJob: Đã gửi 5 nhắc nhở công nợ khách hàng và 2 lịch cảnh báo bảo trì phương tiện.");
        }
    }
}

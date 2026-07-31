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
            _logger.LogInformation("BackupJob: Bắt đầu sao lưu định kỳ cơ sở dữ liệu hệ thống lúc {time}...", DateTime.UtcNow);
            
            // Giả lập nén DB SQL Server và đẩy bản backup lên lưu trữ đám mây an toàn
            await Task.Delay(3000);

            _logger.LogInformation("BackupJob: Backup thành công. Đã lưu trữ file SmartLogistics_Backup_{date}.bak.", DateTime.UtcNow.ToString("yyyyMMdd_HHmmss"));
        }
    }
}

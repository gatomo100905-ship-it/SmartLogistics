using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class BusinessAnalysisService
    {
        public async Task<string> AnalyzePerformanceTrendAsync(double warehouseUsage, double onTimeRate, decimal monthlyRevenue)
        {
            await Task.Delay(80);
            var sb = new StringBuilder();
            sb.AppendLine("=== BÁO CÁO PHÂN TÍCH HIỆU QUẢ HOẠT ĐỘNG (AI ANALYTICS) ===");
            
            // 1. Warehouse comment
            if (warehouseUsage > 0.8)
            {
                sb.AppendLine("- Kho bãi: Tải lượng kho rất cao (>80%). Cảnh báo nguy cơ ùn tắc hàng hóa. Đề xuất luân chuyển hàng bớt sang kho Miền Nam.");
            }
            else
            {
                sb.AppendLine("- Kho bãi: Tải lượng kho bình thường, hoạt động xuất nhập ổn định.");
            }

            // 2. Delivery comment
            if (onTimeRate < 0.95)
            {
                sb.AppendLine($"- Giao hàng: Tỷ lệ đúng giờ đạt {onTimeRate * 100}%. Dưới chỉ tiêu 95%. Lý do chính: thời tiết xấu. Đề xuất tối ưu hóa lịch trình.");
            }
            else
            {
                sb.AppendLine($"- Giao hàng: Tỷ lệ đúng giờ đạt {onTimeRate * 100}%. Đạt chỉ tiêu chất lượng.");
            }

            // 3. Finance comment
            sb.AppendLine($"- Tài chính: Doanh thu tháng đạt {monthlyRevenue:N0} VND. Dòng tiền ổn định.");
            
            return sb.ToString();
        }
    }
}

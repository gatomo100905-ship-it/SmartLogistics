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
            sb.AppendLine("=== BĂO CĂO PHĂ‚N TĂCH HIá»†U QUáº¢ HOáº T Äá»˜NG (AI ANALYTICS) ===");
            
            // 1. Warehouse comment
            if (warehouseUsage > 0.8)
            {
                sb.AppendLine("- Kho bĂ£i: Táº£i lÆ°á»£ng kho ráº¥t cao (>80%). Cáº£nh bĂ¡o nguy cÆ¡ Ă¹n táº¯c hĂ ng hĂ³a. Äá» xuáº¥t luĂ¢n chuyá»ƒn hĂ ng bá»›t sang kho Miá»n Nam.");
            }
            else
            {
                sb.AppendLine("- Kho bĂ£i: Táº£i lÆ°á»£ng kho bĂ¬nh thÆ°á»ng, hoáº¡t Ä‘á»™ng xuáº¥t nháº­p á»•n Ä‘á»‹nh.");
            }

            // 2. Delivery comment
            if (onTimeRate < 0.95)
            {
                sb.AppendLine($"- Giao hĂ ng: Tá»· lá»‡ Ä‘Ăºng giá» Ä‘áº¡t {onTimeRate * 100}%. DÆ°á»›i chá»‰ tiĂªu 95%. LĂ½ do chĂ­nh: thá»i tiáº¿t xáº¥u. Äá» xuáº¥t tá»‘i Æ°u hĂ³a lá»‹ch trĂ¬nh.");
            }
            else
            {
                sb.AppendLine($"- Giao hĂ ng: Tá»· lá»‡ Ä‘Ăºng giá» Ä‘áº¡t {onTimeRate * 100}%. Äáº¡t chá»‰ tiĂªu cháº¥t lÆ°á»£ng.");
            }

            // 3. Finance comment
            sb.AppendLine($"- TĂ i chĂ­nh: Doanh thu thĂ¡ng Ä‘áº¡t {monthlyRevenue:N0} VND. DĂ²ng tiá»n á»•n Ä‘á»‹nh.");
            
            return sb.ToString();
        }
    }
}

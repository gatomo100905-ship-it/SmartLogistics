using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class ChatbotService
    {
        public async Task<string> AskOpenAIAsync(string prompt, string context)
        {
            await Task.Delay(150); // Simulate OpenAI API request
            // Mock response
            if (prompt.ToLower().Contains("delay") || prompt.ToLower().Contains("trễ"))
            {
                return "AI: Chuyến đi #TR-881 đang trễ khoảng 20 phút do mật độ giao thông tăng tại Quốc lộ 1A.";
            }
            return $"AI: Tôi đã ghi nhận yêu cầu của bạn về '{prompt}' trong ngữ cảnh '{context}'. Tôi có thể giúp gì thêm cho bạn?";
        }
    }
}

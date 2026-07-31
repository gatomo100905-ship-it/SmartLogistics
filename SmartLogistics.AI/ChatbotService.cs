using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class ChatbotService
    {
        public async Task<string> AskOpenAIAsync(string prompt, string context)
        {
            await Task.Delay(150); // Simulate OpenAI API request
            // Mock response
            if (prompt.ToLower().Contains("delay") || prompt.ToLower().Contains("trá»…"))
            {
                return "AI: Chuyáº¿n Ä‘i #TR-881 Ä‘ang trá»… khoáº£ng 20 phĂºt do máº­t Ä‘á»™ giao thĂ´ng tÄƒng táº¡i Quá»‘c lá»™ 1A.";
            }
            return $"AI: TĂ´i Ä‘Ă£ ghi nháº­n yĂªu cáº§u cá»§a báº¡n vá» '{prompt}' trong ngá»¯ cáº£nh '{context}'. TĂ´i cĂ³ thá»ƒ giĂºp gĂ¬ thĂªm cho báº¡n?";
        }
    }
}

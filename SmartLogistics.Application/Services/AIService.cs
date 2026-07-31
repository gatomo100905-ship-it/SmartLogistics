using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IAIService
    {
        Task<object> ExtractInvoiceDetailsAsync(byte[] imageBytes);
        Task<string> GetChatbotResponseAsync(string userMessage);
    }

    public class AIService : IAIService
    {
        public async Task<object> ExtractInvoiceDetailsAsync(byte[] imageBytes)
        {
            await Task.Delay(100); // Simulate OCR model run
            return new { InvoiceNumber = "INV-OCR-11", TaxCode = "0102030405", Amount = 15000000.00m };
        }

        public async Task<string> GetChatbotResponseAsync(string userMessage)
        {
            await Task.Delay(50);
            return "AI Response to: " + userMessage;
        }
    }
}

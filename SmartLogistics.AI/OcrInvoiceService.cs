using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class OcrInvoiceService
    {
        public async Task<object> ParseInvoiceImageAsync(byte[] imageBytes)
        {
            await Task.Delay(120); // Simulate Cloud Vision OCR
            return new
            {
                InvoiceNumber = "INV-2026-9921",
                VendorName = "Hanoi Fuel Co.",
                TaxCode = "0109923812",
                SubTotal = 1500000.00m,
                TaxRate = 0.10,
                TotalAmount = 1650000.00m,
                ConfidenceScore = 0.96
            };
        }
    }
}

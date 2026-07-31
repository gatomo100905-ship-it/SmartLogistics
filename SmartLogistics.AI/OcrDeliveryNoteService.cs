using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class OcrDeliveryNoteService
    {
        public async Task<object> ParseDeliveryNoteAsync(byte[] imageBytes)
        {
            await Task.Delay(120);
            return new
            {
                DeliveryNoteNumber = "DN-8831",
                RecipientName = "Warehouse B Manager",
                DeliveryAddress = "KCN Cat Lai, TP.HCM",
                ReceivedItems = new[] {
                    new { Sku = "SKU-BOX-M", Qty = 100 },
                    new { Sku = "SKU-PAL-W", Qty = 5 }
                },
                ConfidenceScore = 0.94
            };
        }
    }
}

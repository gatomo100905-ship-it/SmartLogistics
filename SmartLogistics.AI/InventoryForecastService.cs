using System;
using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class InventoryForecastService
    {
        public async Task<object> PredictReorderNeedsAsync(string sku, int currentStock, int averageDailySales)
        {
            await Task.Delay(50);
            var leadTimeDays = 5;
            var safetyStock = averageDailySales * 2;
            var reorderPoint = (averageDailySales * leadTimeDays) + safetyStock;
            var needsReorder = currentStock <= reorderPoint;
            var suggestedQty = needsReorder ? (averageDailySales * 30) : 0; // order 30 days of sales

            return new
            {
                ProductSku = sku,
                CurrentStock = currentStock,
                ReorderPoint = reorderPoint,
                NeedsReorder = needsReorder,
                SuggestedOrderQuantity = suggestedQty,
                DaysUntilStockout = currentStock / Math.Max(1, averageDailySales)
            };
        }
    }
}

using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SmartLogistics.SignalR
{
    public class WarehouseStatusHub : Hub
    {
        public async Task SubscribeToWarehouse(int warehouseId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"Warehouse_{warehouseId}");
        }

        public async Task UnsubscribeFromWarehouse(int warehouseId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"Warehouse_{warehouseId}");
        }

        public async Task SendStatusUpdate(int warehouseId, double occupiedSpaceM3, double filledPercentage)
        {
            // Broadcast real-time stock space occupancy changes to warehouse monitors
            await Clients.Group($"Warehouse_{warehouseId}").SendAsync("ReceiveWarehouseStatus", new
            {
                WarehouseId = warehouseId,
                OccupiedSpaceM3 = occupiedSpaceM3,
                FilledPercentage = filledPercentage,
                Timestamp = System.DateTime.UtcNow
            });
        }
    }
}

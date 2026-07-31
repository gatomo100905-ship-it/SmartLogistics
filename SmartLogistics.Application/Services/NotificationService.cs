using System;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface INotificationService
    {
        Task<bool> SendPushNotificationAsync(Guid userId, string title, string message);
        Task<bool> MarkAsReadAsync(Guid notificationId);
    }

    public class NotificationService : INotificationService
    {
        public async Task<bool> SendPushNotificationAsync(Guid userId, string title, string message)
        {
            await Task.Delay(20);
            return true;
        }

        public async Task<bool> MarkAsReadAsync(Guid notificationId)
        {
            await Task.Delay(10);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IDriverService
    {
        Task<IEnumerable<object>> GetAvailableDriversAsync();
        Task<bool> UpdateDriverStatusAsync(Guid driverId, string status);
    }

    public class DriverService : IDriverService
    {
        public async Task<IEnumerable<object>> GetAvailableDriversAsync()
        {
            await Task.Delay(50);
            return new List<object> { new { Id = Guid.NewGuid(), Name = "Nguyen Van Driver", License = "FC" } };
        }

        public async Task<bool> UpdateDriverStatusAsync(Guid driverId, string status)
        {
            await Task.Delay(50);
            return true;
        }
    }
}

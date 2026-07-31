using System;
using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.Identity
{
    public class IdentityService
    {
        public async Task<object> RegisterUserAsync(string email, string password)
        {
            await Task.Delay(50); // Simulate database insert
            return new { Success = true, UserId = Guid.NewGuid(), Message = "User registered successfully under ASP.NET Core Identity." };
        }

        public async Task<object> LoginAsync(string email, string password)
        {
            await Task.Delay(50);
            if (email == "admin@smartlogistics.com" && password == "Password123!")
            {
                return new { Success = true, Role = "Admin", UserId = Guid.NewGuid() };
            }
            return new { Success = false, Message = "Invalid credentials." };
        }
    }
}

using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.MicrosoftLogin
{
    public class MicrosoftAuthService
    {
        public async Task<object> VerifyMicrosoftTokenAsync(string token)
        {
            await Task.Delay(100); // Simulate Microsoft Graph validation
            return new
            {
                MicrosoftId = "ms-unique-user-id-9921",
                Email = "ms.user@microsoft.com",
                DisplayName = "Microsoft User"
            };
        }
    }
}

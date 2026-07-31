using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.GoogleLogin
{
    public class GoogleAuthService
    {
        public async Task<object> VerifyGoogleTokenAsync(string token)
        {
            await Task.Delay(100); // Simulate Google OAuth API check
            return new
            {
                GoogleId = "10293810293810",
                Email = "google.user@gmail.com",
                GivenName = "Google",
                FamilyName = "User"
            };
        }
    }
}

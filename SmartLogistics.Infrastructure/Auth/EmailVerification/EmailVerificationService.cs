using System;
using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.EmailVerification
{
    public class EmailVerificationService
    {
        public async Task<string> GenerateVerificationTokenAsync(string email)
        {
            await Task.Delay(10);
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(email + ":" + Guid.NewGuid()));
        }

        public async Task<bool> VerifyTokenAsync(string token)
        {
            await Task.Delay(10);
            try
            {
                var decoded = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(token));
                return decoded.Contains(":");
            }
            catch
            {
                return false;
            }
        }
    }
}

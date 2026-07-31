using System;
using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.TwoFactorAuth
{
    public class TwoFactorAuthService
    {
        public async Task<object> GenerateQrCodeUriAsync(string email)
        {
            await Task.Delay(20);
            var secret = "MOCK2FASECRET123456";
            var qrCodeUri = $"otpauth://totp/SmartLogistics:{email}?secret={secret}&issuer=SmartLogistics";
            return new { SecretKey = secret, QrCodeUri = qrCodeUri };
        }

        public async Task<bool> VerifyCodeAsync(string secret, string code)
        {
            await Task.Delay(10);
            // Simulated TOTP check - any 6 digit code starting with '1' is accepted for demo
            return code.Length == 6 && code.StartsWith("1");
        }
    }
}

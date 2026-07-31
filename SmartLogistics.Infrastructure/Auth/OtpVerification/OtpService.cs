using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SmartLogistics.Infrastructure.Auth.OtpVerification
{
    public class OtpService
    {
        private static readonly ConcurrentDictionary<string, string> _otpStorage = new ConcurrentDictionary<string, string>();

        public async Task<string> GenerateOtpAsync(string phoneNumber)
        {
            await Task.Delay(10);
            var random = new Random();
            var otp = random.Next(100000, 999999).ToString();
            _otpStorage[phoneNumber] = otp;
            return otp;
        }

        public async Task<bool> VerifyOtpAsync(string phoneNumber, string otp)
        {
            await Task.Delay(10);
            if (_otpStorage.TryGetValue(phoneNumber, out var savedOtp))
            {
                if (savedOtp == otp)
                {
                    _otpStorage.TryRemove(phoneNumber, out _);
                    return true;
                }
            }
            return false;
        }
    }
}

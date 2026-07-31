using System.Threading.Tasks;

namespace SmartLogistics.AI
{
    public class DelayPredictionService
    {
        public async Task<object> PredictDelayRiskAsync(string route, string weather, double trafficCongestionIndex)
        {
            await Task.Delay(50);
            var riskScore = 0.10; // 10% base risk
            
            if (weather.ToLower() == "rain") riskScore += 0.15;
            if (weather.ToLower() == "storm") riskScore += 0.40;
            riskScore += trafficCongestionIndex * 0.30;
            
            riskScore = System.Math.Min(1.0, riskScore);

            return new
            {
                Route = route,
                DelayProbability = riskScore,
                RiskLevel = riskScore > 0.6 ? "High" : (riskScore > 0.3 ? "Medium" : "Low"),
                Recommendation = riskScore > 0.6 ? "Alternative Route Advisable" : "Standard Route OK"
            };
        }
    }
}

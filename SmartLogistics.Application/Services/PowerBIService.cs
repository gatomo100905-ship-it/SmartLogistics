using System.Threading.Tasks;

namespace SmartLogistics.Application.Services
{
    public interface IPowerBIService
    {
        Task<object> GetReportEmbedTokenAsync(string reportId, string workspaceId);
    }

    public class PowerBIService : IPowerBIService
    {
        public async Task<object> GetReportEmbedTokenAsync(string reportId, string workspaceId)
        {
            await Task.Delay(50);
            return new { EmbedUrl = "https://app.powerbi.com/reportEmbed?reportId=" + reportId, Token = "pbi_token_dummy_123" };
        }
    }
}

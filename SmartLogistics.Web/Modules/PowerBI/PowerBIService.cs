using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.PowerBI
{
    public interface IPowerBIService
    {
        // Interface declaration placeholder
    }

    public class PowerBIService : IPowerBIService
    {
        public object GetEmbedToken(string reportId) { return new { Token = "pbi_embed_token_dummy", Expiry = System.DateTime.Now.AddHours(1) }; }
    }
}

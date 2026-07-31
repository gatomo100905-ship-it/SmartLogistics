using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.CRM
{
    public interface ICRMService
    {
        // Interface declaration placeholder
    }

    public class CRMService : ICRMService
    {
        public object GetSalesPipeline() { return new { ActiveLeads = 12, ProposalSent = 5, ClosedWon = 8 }; }
    }
}

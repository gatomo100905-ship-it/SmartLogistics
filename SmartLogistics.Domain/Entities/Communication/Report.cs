using System;

namespace SmartLogistics.Domain.Entities.Communication
{
    public class Report
    {
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public string ReportType { get; set; } // e.g. "Financial", "Operational", "FleetSummary"
        public Guid GeneratedBy { get; set; } // User ID who generated it
        public DateTime GenerationTime { get; set; } = DateTime.UtcNow;
        public string ParametersJson { get; set; } // Search parameters serialized
        public string FilePath { get; set; } // Path to PDF/Excel on storage server
        public string Status { get; set; } // e.g. "Pending", "Completed", "Failed"
    }
}

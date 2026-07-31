namespace SmartLogistics.Web.Modules.AI
{
    public class AIViewModel
    {
        public string PredictionModelName { get; set; }
        public string InputDataSummary { get; set; }
        public string OutputResultJson { get; set; }
        public double ConfidenceScore { get; set; }
    }
}

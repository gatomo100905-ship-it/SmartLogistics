using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Reports
{
    public class ReportsController : Controller
    {
        private readonly ILogger<ReportsController> _logger;
        private readonly IReportsService _service;

        public ReportsController(ILogger<ReportsController> logger, IReportsService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Reports Module index page.");
            var viewModel = new ReportsViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

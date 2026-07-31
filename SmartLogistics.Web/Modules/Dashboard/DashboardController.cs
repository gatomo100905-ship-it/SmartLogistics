using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Dashboard
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly IDashboardService _service;

        public DashboardController(ILogger<DashboardController> logger, IDashboardService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Dashboard Module index page.");
            var viewModel = new DashboardViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

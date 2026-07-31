using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Dashboard index page.");
            // View data / stats placeholder
            ViewData["TotalShipments"] = 1250;
            ViewData["ActiveDrivers"] = 45;
            ViewData["CompletedOrders"] = 11200;
            ViewData["PendingAlerts"] = 3;
            
            return View();
        }
    }
}

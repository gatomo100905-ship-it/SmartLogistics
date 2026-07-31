using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Vehicle
{
    public class VehicleController : Controller
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleService _service;

        public VehicleController(ILogger<VehicleController> logger, IVehicleService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Vehicle Module index page.");
            var viewModel = new VehicleViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

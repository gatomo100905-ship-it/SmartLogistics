using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Shipment
{
    public class ShipmentController : Controller
    {
        private readonly ILogger<ShipmentController> _logger;
        private readonly IShipmentService _service;

        public ShipmentController(ILogger<ShipmentController> logger, IShipmentService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Shipment Module index page.");
            var viewModel = new ShipmentViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

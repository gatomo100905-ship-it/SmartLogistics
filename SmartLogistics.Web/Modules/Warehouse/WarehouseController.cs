using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Warehouse
{
    public class WarehouseController : Controller
    {
        private readonly ILogger<WarehouseController> _logger;
        private readonly IWarehouseService _service;

        public WarehouseController(ILogger<WarehouseController> logger, IWarehouseService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Warehouse Module index page.");
            var viewModel = new WarehouseViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

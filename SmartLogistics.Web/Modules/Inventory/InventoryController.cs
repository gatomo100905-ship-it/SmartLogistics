using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Inventory
{
    public class InventoryController : Controller
    {
        private readonly ILogger<InventoryController> _logger;
        private readonly IInventoryService _service;

        public InventoryController(ILogger<InventoryController> logger, IInventoryService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Inventory Module index page.");
            var viewModel = new InventoryViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

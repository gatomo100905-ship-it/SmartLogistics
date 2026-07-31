using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Supplier
{
    public class SupplierController : Controller
    {
        private readonly ILogger<SupplierController> _logger;
        private readonly ISupplierService _service;

        public SupplierController(ILogger<SupplierController> logger, ISupplierService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Supplier Module index page.");
            var viewModel = new SupplierViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

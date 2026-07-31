using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Purchase
{
    public class PurchaseController : Controller
    {
        private readonly ILogger<PurchaseController> _logger;
        private readonly IPurchaseService _service;

        public PurchaseController(ILogger<PurchaseController> logger, IPurchaseService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Purchase Module index page.");
            var viewModel = new PurchaseViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

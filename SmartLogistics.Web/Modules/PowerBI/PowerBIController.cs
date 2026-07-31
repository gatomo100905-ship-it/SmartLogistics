using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.PowerBI
{
    public class PowerBIController : Controller
    {
        private readonly ILogger<PowerBIController> _logger;
        private readonly IPowerBIService _service;

        public PowerBIController(ILogger<PowerBIController> logger, IPowerBIService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing PowerBI Module index page.");
            var viewModel = new PowerBIViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

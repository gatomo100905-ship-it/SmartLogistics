using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Drivers
{
    public class DriversController : Controller
    {
        private readonly ILogger<DriversController> _logger;
        private readonly IDriversService _service;

        public DriversController(ILogger<DriversController> logger, IDriversService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Drivers Module index page.");
            var viewModel = new DriversViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

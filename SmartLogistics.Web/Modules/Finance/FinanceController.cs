using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Finance
{
    public class FinanceController : Controller
    {
        private readonly ILogger<FinanceController> _logger;
        private readonly IFinanceService _service;

        public FinanceController(ILogger<FinanceController> logger, IFinanceService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Finance Module index page.");
            var viewModel = new FinanceViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

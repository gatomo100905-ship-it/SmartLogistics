using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.CRM
{
    public class CRMController : Controller
    {
        private readonly ILogger<CRMController> _logger;
        private readonly ICRMService _service;

        public CRMController(ILogger<CRMController> logger, ICRMService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing CRM Module index page.");
            var viewModel = new CRMViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

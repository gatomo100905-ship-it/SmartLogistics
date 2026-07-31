using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Accounting
{
    public class AccountingController : Controller
    {
        private readonly ILogger<AccountingController> _logger;
        private readonly IAccountingService _service;

        public AccountingController(ILogger<AccountingController> logger, IAccountingService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Accounting Module index page.");
            var viewModel = new AccountingViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

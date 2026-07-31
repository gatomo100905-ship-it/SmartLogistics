using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Employees
{
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeesService _service;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Employees Module index page.");
            var viewModel = new EmployeesViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

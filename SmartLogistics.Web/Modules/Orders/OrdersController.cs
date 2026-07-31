using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Modules.Orders
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrdersService _service;

        public OrdersController(ILogger<OrdersController> logger, IOrdersService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Accessing Orders Module index page.");
            var viewModel = new OrdersViewModel();
            // Map or fetch data to viewModel here
            return View(viewModel);
        }
    }
}

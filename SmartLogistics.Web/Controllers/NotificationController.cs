using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace SmartLogistics.Web.Controllers
{
    public class NotificationController : Controller
    {
        private readonly ILogger<NotificationController> _logger;

        public NotificationController(ILogger<NotificationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Retrieving notifications list.");
            
            // Dummy list of notifications
            var notifications = new List<object>
            {
                new { Id = 1, Title = "New Shipment Assigned", Message = "Shipment #SH-9831 has been assigned to driver John Doe.", CreatedAt = DateTime.Now.AddMinutes(-15), IsRead = false },
                new { Id = 2, Title = "Delayed Delivery Alert", Message = "Route #R-2290 is experiencing unexpected delays.", CreatedAt = DateTime.Now.AddHours(-2), IsRead = false },
                new { Id = 3, Title = "Invoice Cleared", Message = "Invoice #INV-0091 for Client Alpha has been paid.", CreatedAt = DateTime.Now.AddDays(-1), IsRead = true }
            };

            return View(notifications);
        }

        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            _logger.LogInformation("Marking notification {Id} as read.", id);
            // Dummy update logic
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult MarkAllAsRead()
        {
            _logger.LogInformation("Marking all notifications as read.");
            // Dummy update logic
            return RedirectToAction(nameof(Index));
        }
    }
}

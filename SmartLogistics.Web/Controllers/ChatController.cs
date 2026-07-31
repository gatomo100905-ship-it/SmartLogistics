using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace SmartLogistics.Web.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;

        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Opening chat module.");
            
            // Dummy list of recent conversations
            var contacts = new List<object>
            {
                new { UserId = "user-1", Name = "John Doe (Driver)", Role = "Driver", Avatar = "/images/avatars/user-1.jpg", LastMessage = "I have arrived at the warehouse.", IsOnline = true },
                new { UserId = "user-2", Name = "Sarah Smith (HR)", Role = "HR", Avatar = "/images/avatars/user-2.jpg", LastMessage = "Please submit the invoice today.", IsOnline = false },
                new { UserId = "user-3", Name = "Alex Wong (Support)", Role = "Support", Avatar = "/images/avatars/user-3.jpg", LastMessage = "How can I help you?", IsOnline = true }
            };

            ViewData["Contacts"] = contacts;
            return View();
        }

        [HttpGet]
        public IActionResult GetMessages(string userId)
        {
            _logger.LogInformation("Fetching chat messages for conversation with user: {UserId}", userId);
            
            // Dummy messages list
            var messages = new List<object>
            {
                new { SenderId = userId, Content = "Hello, I am on my way.", Timestamp = DateTime.Now.AddHours(-1) },
                new { SenderId = "current-user", Content = "Sounds good. Drive safe!", Timestamp = DateTime.Now.AddMinutes(-50) },
                new { SenderId = userId, Content = "I have arrived at the warehouse.", Timestamp = DateTime.Now.AddMinutes(-10) }
            };

            return Json(messages);
        }
    }
}

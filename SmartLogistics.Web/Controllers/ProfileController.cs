using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SmartLogistics.Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Viewing user profile.");
            // Dummy user details
            ViewData["FullName"] = "Hoàng Nguyễn Đức";
            ViewData["Email"] = "hoangaxm09@gmail.com";
            ViewData["Role"] = "System Administrator";
            ViewData["Phone"] = "+84 987654321";
            
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            // Dummy user details for edit
            ViewData["FullName"] = "Hoàng Nguyễn Đức";
            ViewData["Email"] = "hoangaxm09@gmail.com";
            ViewData["Phone"] = "+84 987654321";
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string fullName, string phone)
        {
            _logger.LogInformation("Updating profile for user: {FullName}", fullName);
            // Dummy save logic
            TempData["SuccessMessage"] = "Profile updated successfully!";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            _logger.LogInformation("User attempting to change password.");
            if (newPassword != confirmPassword)
            {
                ModelState.AddModelError(string.Empty, "New passwords do not match.");
                return View();
            }

            // Dummy change password logic
            TempData["SuccessMessage"] = "Password changed successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}

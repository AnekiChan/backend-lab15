using Microsoft.AspNetCore.Mvc;

namespace Lab15.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var role = User.IsInRole("admin") ? "admin" : User.IsInRole("user") ? "user" : "guest";
            ViewBag.Role = role;
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}

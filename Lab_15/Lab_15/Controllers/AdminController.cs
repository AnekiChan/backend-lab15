using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab_15.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AdminController : ControllerBase
    {
        public IActionResult Index()
        {
            var role = "Admin";
            return Ok($"Welcome, {role}! You are viewing the admin index page.");
        }
    }
}

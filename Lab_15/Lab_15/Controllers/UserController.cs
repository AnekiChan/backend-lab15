using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab_15.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        public IActionResult Index()
        {
            var role = "User";
            return Ok($"Welcome, {role}! You are viewing the user index page.");
        }
    }
}

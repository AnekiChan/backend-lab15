using Microsoft.AspNetCore.Mvc;

namespace Lab_15.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ChooseRole(string role)
        {
            if (role == "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (role == "User")
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}

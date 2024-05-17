using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab15.Controllers
{
    public class PostsController : Controller
    {
        private static List<string> posts = new List<string>();

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult AddPost(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                posts.Add(content);
            }
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult Index()
        {
            ViewBag.Posts = posts;
            ViewBag.IsAdmin = User.IsInRole("admin");
            return View();
        }
    }
}

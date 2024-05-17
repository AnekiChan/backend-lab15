using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

[Authorize]
public class PostsIndexModel : PageModel
{
    public static List<string> Posts { get; private set; } = new List<string>();

    public bool IsAdmin { get; private set; }

    public void OnGet()
    {
        IsAdmin = User.IsInRole("admin");
    }

    public IActionResult OnPost(string content)
    {
        if (User.IsInRole("admin") && !string.IsNullOrEmpty(content))
        {
            Posts.Add(content);
        }
        return RedirectToPage();
    }
}
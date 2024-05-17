using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string Role { get; private set; }

    public void OnGet()
    {
        Role = User.IsInRole("admin") ? "admin" : User.IsInRole("user") ? "user" : "guest";
    }
}
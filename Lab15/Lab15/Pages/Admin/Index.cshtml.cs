using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize(Roles = "admin")]
public class AdminIndexModel : PageModel
{
    public string Message { get; private set; } = "Панель администратора";
}
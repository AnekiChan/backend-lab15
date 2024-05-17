namespace Lab_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();
            app.MapControllers();

            app.Use(async (context, next) =>
            {
                var user = context.User;

                if (user.Identity.IsAuthenticated)
                {
                    var isAdmin = user.IsInRole("Admin");

                    if (context.Request.Path == "/" || context.Request.Path == "/Index")
                    {
                        if (isAdmin)
                        {
                            context.Response.Redirect("/Admin/Index");
                        }
                        else
                        {
                            context.Response.Redirect("/User/Index");
                        }
                    }
                }

                await next();
            });

            app.Run();
        }
    }
}

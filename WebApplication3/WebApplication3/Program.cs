using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication3.DAL;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBC>(options =>
            options.UseSqlServer("server=DESKTOP-QQIUMB0;database=StoriesWA;Trusted_connection=true;Integrated security=true;encrypt=false")
        );


            var app = builder.Build();


            app.UseStaticFiles();


            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}
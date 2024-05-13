using PhoniaTask.DAL;
using Microsoft.EntityFrameworkCore;

namespace PhoniaTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<PhoniaContext>(opt=>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSql"));
            });
            var app = builder.Build();



            app.UseStaticFiles();
            app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
            app.MapControllerRoute(
                "default",
                "{controller=Home}/{action=Index}"
                );

            app.Run();
        }
    }
}
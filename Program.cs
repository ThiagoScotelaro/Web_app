using Contact_Management_Web_application.Data;
using Contact_Management_Web_application.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contact_Management_Web_application
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string mySqlconnection = builder.Configuration.GetConnectionString("MariaDB");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContextPool<BancoContext>
                (Options => Options.UseMySql(mySqlconnection, ServerVersion.AutoDetect(mySqlconnection)));
            builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
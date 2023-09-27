using Api_Mvc.Data;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        // Add services to the container.
        builder.Services.AddControllersWithViews();
        //Configuracion de conexion de base de datos, inyeccion de dependecia
        //Connectionstring hacia mi base de datos, revisar en el appsettings.json el conectionstring en este caso es ProductosContext
        var connectionString = builder.Configuration.GetConnectionString("ProductosContext");

        builder.Services.AddDbContext<Api_Mvc.Data.ProductosContext>(

            options => options.UseSqlite(connectionString)

        );
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
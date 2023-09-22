using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebApiMvc.Models;

namespace WebApiMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Para la vista revisar en Views/Home/Index.cshtml
        ViewBag.Menssage1 = "Este es un mensaje desde el controlador con ViewBag";
        ViewBag.Contador1 = 10;
        
        ViewData["Mensaje2"] = "Este es un mensaje desde el controlador con ViewData";
        ViewData["Contador2"] = 20;
        //Decimal r
        ViewBag.Precio1 = 12.3m;
        ViewData["Precio2"] = 201.45m;
        //Fehcas
        ViewBag.Fecha1 = DateTime.Now;
        ViewData["Fecha2"] = DateTime.Now.AddDays(1);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

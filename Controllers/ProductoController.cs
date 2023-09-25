using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Api_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiMvc.Models;


namespace Api_Mvc.Controllers
{
    
    public class ProductoController : Controller
    {
       
        public List<Producto>? Productos { get; set; }
        //Este metodo me devuelve una vista
        public IActionResult Index()
        {
            //Regresa una vista
            var productos = GetData();
            return View(productos);
            //return View();
        }

        // Metodo del controladr que devuelve los datos de un producto
        
        public List<Producto> GetData()
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto{
                Id=1,
                Nombre = "Coca-cola",
                Descripcion ="Gaseosa",
                Precio = 850.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});
                productos.Add(new Producto{
                Id=2,
                Nombre = "Cafe Juan Valdez",
                Descripcion ="Cafe",
                Precio = 180.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});
                productos.Add(new Producto{
                Id=3,
                Nombre = "Cafe fiero",
                Descripcion ="Cafe",
                Precio = 20.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});
                productos.Add(new Producto{
                Id=3,
                Nombre = "IPA VERA",
                Descripcion ="Cerveza",
                Precio = 900.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});
                productos.Add(new Producto{
                Id=4,
                Nombre = "Agua Villacencio",
                Descripcion ="Agua",
                Precio = 450.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});
                productos.Add(new Producto{
                Id=5,
                Nombre = "Leche milca",
                Descripcion ="Leche",
                Precio = 250.00m,
                Activo=true,
                FechaDeAlta = DateTime.Now.AddDays(-1)});

                return productos;
                
        } 
    }
}
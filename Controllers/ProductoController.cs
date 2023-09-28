using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Api_Mvc.Data;
using Api_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SQLitePCL;
using WebApiMvc.Models;


namespace Api_Mvc.Controllers
{
    
    public class ProductoController : Controller
    {
        //Inyectamos desde la base de datos
        private readonly ProductosContext _context;
        public ProductoController(ProductosContext context)
        {
            _context = context;
        }
       
        public List<Producto>? Productos { get; set; }
        //Este metodo me devuelve una vista
        public async Task<IActionResult> Index()
        {
            //Trae lo que tengamos en la base de datos
            var productos = await _context.Productos.ToListAsync();
            return View(productos);
        }
        //Metodo GET 
        //Localhost/producto/create
        public IActionResult Create()
        {
            return View();
        }
        // Metodo GET localhost/Producto/Edit
        // Metodo para editar un producto
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if(id==0)
                return NotFound();
            //Nos devuelve el
            var producto = await _context.Productos.FindAsync(id);
            if(producto == null)
                return NotFound();
            
            return View(producto);
            

        }
        //Metodo GET GET localhost/Producto/Delete/id
        //Regresamos el producto
        public async Task<IActionResult> Delete(int id)
        {
            if(id==0)
                return NotFound();
            
            var producto = await _context.Productos.FindAsync(id);
            if(producto == null)
                return NotFound();
            
            return View(producto);
        }

        //Metodo POST
        //Localhost/producto/Create
        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {
            //Se Valida el producto que se va a agregar
            if(ModelState.IsValid)
            {
                //DbSet<Producto>
                producto.FechaDeAlta = DateTime.Now;
                _context.Add(producto);
                await _context.SaveChangesAsync();
                //Redireccion a index
                return RedirectToAction(nameof(Index));
            }
            
            return View(producto);
        }
        //Metodo POST
        //Localhost/producto/Edit/id
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producto producto)
        {
            if(id != producto.Id)
                return NotFound();
            //Guardamos los cambios del edit
            if(ModelState.IsValid)
            {
                producto.FechaDeAlta = DateTime.Now;
                _context.Update(producto);
                await _context.SaveChangesAsync();
                //Redireccion a index
                return RedirectToAction(nameof(Index));
            }

            return View(producto);
        }
        //Metodo POST
        //Localhost/producto/Delete/id
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
    
        }
    }
}
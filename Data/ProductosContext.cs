using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Mvc.Data
{
    //Clase que hereda de dbcontext 
    public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options) 
        :base(options)
        {
            //Inyectamos nuestras dependecias 
        }
        //Tabla de donde saca los datos
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

    }
}
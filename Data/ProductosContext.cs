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
        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options)
        {
            //Inyectamos nuestras dependecias 
            //Apartir del modelo se crean las bases de datos 
            //Los datos van a persistir en una base de datos 
        }
        //En nuestro contexto de base de datos va a tener un conjuto de productos y un conjunto de usuarios
        // representados por los modelos producto y usuarios
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
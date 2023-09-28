using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; //Importamos Data Annotatios

namespace Api_Mvc.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="EL nombre es requerido")]
        //[MaxLength(30)]Maximo de longitud o [MinLenght()] para el minimo de longitud
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="La descripcion es requerida")]
        [Display(Name = "Descripcion")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage ="EL precio es requerido")]
        [Display(Name = "Precio USD")]
        public decimal Precio {get; set; }
        public bool Activo {get; set; }

        [DataType(DataType.DateTime)] //Hacemos que el usuario valide la fecha

        public DateTime FechaDeAlta {get; set; } 

        //Para los correros podemos usar expresiones regulares para los correos por ejemplo
        // [RegularExpression("")]
        
    }

}
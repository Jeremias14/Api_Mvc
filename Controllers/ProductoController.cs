using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api_Mvc.Controllers
{
    [Route("[controller]")]
    public class ProductoController : Controller
    {
       
        //Este metodo me devuelve una vista
        public IActionResult Index()
        {
            //Regresa una vista
            return View();
        }
    }
}
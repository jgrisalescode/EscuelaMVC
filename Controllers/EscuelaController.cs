using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EscuelaMVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            // IActionResult es una interfáz genérica como IEnumerable, que luego podremos convertir
            return View();
            // Como return View(); no tiene parámetros retorna la vista Index
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscuelaMVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            // IActionResult es una interfáz genérica como IEnumerable, que luego podremos convertir
            // Como return View(); no tiene parámetros retorna la vista Index
            // Creando el modelo en el controlador para enviárselo a la vista
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Dirección = "Calle Mayor";
            escuela.Ciudad = "Bogotá";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            // Tambien podemos enviar más cosas a la Vista por medio de @ViewBag o @ViewData
            ViewBag.CualquierCosa = "Cualquier Cosa";
            return View(escuela); // Envaida a la vista (escuela)
        }
    }
}
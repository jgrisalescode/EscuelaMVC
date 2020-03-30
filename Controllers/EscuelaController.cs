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
        private EscuelaContext _context;
        public IActionResult Index()
        {            
            // Tambien podemos enviar más cosas a la Vista por medio de @ViewBag o @ViewData
            ViewBag.CualquierCosa = "Cualquier Cosa";
            // Trayendo la Escuela desde InMemory
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela); // Envaida a la vista (escuela)
        }

        // Vamos a hacer que llame la escuela desde el Contexto y el nuevo Servicio en Startup.cs
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
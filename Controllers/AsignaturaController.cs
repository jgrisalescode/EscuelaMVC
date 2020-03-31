using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EscuelaMVC.Models;

namespace EscuelaMVC.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Ahora tratendo los datos aque estén en la BD
            return View(_context.Asignaturas.FirstOrDefault());
        }

        public IActionResult MultiAsignatura()
        {
            
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",_context.Asignaturas);
        }
    }
}
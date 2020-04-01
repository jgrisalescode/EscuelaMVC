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

        /*
        * Por convencion el parámetro que recibe la URL que está en Startup.cs es
        * pattern: "{controller=Escuela}/{action=Index}/{id?}");
        * Su nombre es id por lo tanto el parámetro de éste método debe llamarse igual OJO
        * Pero si quiero que el parámetro no sea id sino personalizado, como este que es
        * asignaturaId, debo configurar las rutas de esta manera:
        */
        [Route("Asignatura/Index")] // Por si entran sin parámetro
        [Route("Asignatura/Index/{asignaturaId}")] // El parámetro custom

        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAsignatura", _context.Asignaturas);
            }
        }

        public IActionResult MultiAsignatura()
        {
            
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",_context.Asignaturas);
        }
    }
}
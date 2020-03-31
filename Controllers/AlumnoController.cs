using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EscuelaMVC.Models;

namespace EscuelaMVC.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context;

        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Ve al contexto a por tu alumno
            return View(_context.Alumnos.FirstOrDefault());
        }

        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno",_context.Alumnos);
        }       

    }
}
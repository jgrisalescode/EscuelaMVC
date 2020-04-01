using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EscuelaMVC.Models;

namespace EscuelaMVC.Controllers
{
    public class CursoController : Controller
    {
        private EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id) // Aqui seguimos las convenciones de enrutamiento
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso = from cur in _context.Cursos
                             where cur.Id == id
                             select cur;
                return View(curso.SingleOrDefault());
            } else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }

        public IActionResult MultiCurso()
        {
            return View("MultiCurso",_context.Cursos);
        }

        public IActionResult Create()
        {
            // Con este Método renderizo el formulario
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            // Validando el modelo Curso que tiene la anotacion [Required] en Nombre
            if (ModelState.IsValid)
            {
                // Y con este resuelvo lo que me llega del post
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.Id = Guid.NewGuid().ToString();
                curso.EscuelaID = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra = "Curso Creado";
                return View("Index", curso);
            } else
            {
                return View(curso);
            }
        }

    }
}
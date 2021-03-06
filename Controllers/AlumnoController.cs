﻿using System;
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

        public IActionResult Index(string id) // Aqui seguimos las convenciones de enrutamiento
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alum in _context.Alumnos
                             where alum.Id == id
                             select alum;
                return View(alumno.SingleOrDefault());
            } else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }

        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno",_context.Alumnos);
        }       

    }
}
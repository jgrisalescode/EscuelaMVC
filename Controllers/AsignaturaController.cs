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
        public IActionResult Index()
        {
            var asignatura = new Asignatura
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };
            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }
    }
}
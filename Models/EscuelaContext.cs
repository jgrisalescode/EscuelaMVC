using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscuelaMVC.Models
{
    /// <summary>
    /// Clase que se encarga de gestionar la conexión con la BD InMemory
    /// </summary>
    public class EscuelaContext : DbContext
    {
        // DbSet<Escuela> es un tipo de Listas para Escuela y Escuelas a la tabla en la BD,
        // en plural, por que una tabla guarda muchas escuelas
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciónes { get; set; }

        // Constructor especial
        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options) 
        {

        }
    }
}

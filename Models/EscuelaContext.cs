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

        // Sembrando datos en la BD InMemory
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.Id = Guid.NewGuid().ToString();
            escuela.AñoDeCreación = 2005;
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Bogotá";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Calle Mayor";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            // Mandando la Escuala a la BD
            modelBuilder.Entity<Escuela>().HasData(escuela);

            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura { Nombre = "Matemáticas", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre= "Educación Física", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre= "Castellano", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre= "Ciencias Naturales", Id = Guid.NewGuid().ToString() },
                new Asignatura { Nombre= "Programación", Id = Guid.NewGuid().ToString() }
                );

            // Ahora los alumnos, con un truco por que devuelve una lista GenerarAlumnosAlAzar().ToArray()
            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());
        }

        // Método que se copia de AlumnoControler de forma provisional
        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
    }
}

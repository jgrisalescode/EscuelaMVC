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

            // Enviar a BD ya de acuerdo a los nuevos cambios en el Modelo para ORM
            // Cargar Cursos de la escuela
            var cursos = CargarCursos(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos);
            // Por cada curso cargar: asignaturas
            var asignaturas = CargarAsignaturas(cursos);
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            // Por cada curso cargar: alumnos
            var alumnos = CargarAlumnos(cursos);
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
            // Carga de Evaluaciones

            // Metiendo al modelBuilder
            
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                List<Asignatura> list = new List<Asignatura>
                {
                    new Asignatura { CursoId = curso.Id, Nombre = "Matemáticas", Id = Guid.NewGuid().ToString() },
                    new Asignatura { CursoId = curso.Id, Nombre = "Educación Física", Id = Guid.NewGuid().ToString() },
                    new Asignatura { CursoId = curso.Id, Nombre = "Castellano", Id = Guid.NewGuid().ToString() },
                    new Asignatura { CursoId = curso.Id, Nombre = "Ciencias Naturales", Id = Guid.NewGuid().ToString() },
                    new Asignatura { CursoId = curso.Id, Nombre = "Programación", Id = Guid.NewGuid().ToString() }
                };
                listaCompleta.AddRange(list);
                //curso.Asignaturas = list;
            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>()
            {
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaID = escuela.Id,
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana,
                    Dirección = "Calle Mayor"
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaID = escuela.Id,
                    Nombre = "201",
                    Jornada = TiposJornada.Mañana,
                    Dirección = "Calle Mayor"
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaID = escuela.Id,
                    Nombre = "301",
                    Jornada = TiposJornada.Mañana,
                    Dirección = "Calle Mayor"
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaID = escuela.Id,
                    Nombre = "401",
                    Jornada = TiposJornada.Tarde,
                    Dirección = "Calle Mayor"
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaID = escuela.Id,
                    Nombre = "501",
                    Jornada = TiposJornada.Tarde,
                    Dirección = "Calle Mayor"
                }

            };
        }

        // Método que se copia de AlumnoControler de forma provisional
        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            // Lo alumnos tienen que ir asociado a un curso

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString(),
                                   CursoId = curso.Id
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}

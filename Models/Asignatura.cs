using System;
using System.Collections.Generic;

namespace EscuelaMVC.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        // Tabla padre de Asignatura Curso, a por su referencia
        public string CursoId { get; set; }
        // Navegación
        public Curso Curso { get; set; }

        public List<Evaluación> Evaluaciones { get; set; }
    }
}
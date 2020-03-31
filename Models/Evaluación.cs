using System;

namespace EscuelaMVC.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        /*
         * Análisis de la Evaluación
         * No tiene tablas hijas
         * Tiene referencia a Alumno
         * Tiene referencia a Asignatura
         */

        public string AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public string AsignaturaId { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}
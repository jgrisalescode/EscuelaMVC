using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EscuelaMVC.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        // Sobreescribiendo la propiedad nombre del padre y haciendo que sea requerido
        [Required(ErrorMessage = "El nombre del curso es requerido")]
        [StringLength(5)]
        public override string Nombre { get; set; }

        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        // Por convención, hace referencia al Id de Escuela
        public string EscuelaID { get; set; }
        // Queremos tener el objeto Escuela sin tener que hacer un Query
        // El motor devolverá la Escuela que tenga EscuelaID
        public Escuela Escuela { get; set; }

        [Required(ErrorMessage = "Se requiere una dirección")]
        [MinLength(10, ErrorMessage = "Longitud mínima es 10")]
        // Prompt es Placeholder y Name es Label a nivel de HTML
        [Display(Prompt = "Dirección correspondencia", Name = "Address")]
        public string Dirección { get; set; }        
    }
}
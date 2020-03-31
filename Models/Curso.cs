using System;
using System.Collections.Generic;

namespace EscuelaMVC.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        // Por convención, hace referencia al Id de Escuela
        public string EscuelaID { get; set; }
        // Queremos tener el objeto Escuela sin tener que hacer un Query
        // El motor devolverá la Escuela que tenga EscuelaID
        public Escuela Escuela { get; set; }
        public string Dirección { get; set; }        
    }
}
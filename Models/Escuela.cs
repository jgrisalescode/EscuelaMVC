using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscuelaMVC.Models
{
    public class Escuela
    {
        // Creando nuesto pirmer modelo clase de tipo POCO
        public string EscuelaID { get; set; }
        public string Nombre { get; set; }
        public int AnnioFundacion { get; set; }
    }
}

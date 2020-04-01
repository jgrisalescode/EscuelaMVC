using System;

namespace EscuelaMVC.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        /*
         * Virtual, como esta clase es la padre de los demás modelos, en algunos hijos
         * quiero que el campo Nombre sea obligatorio y en otras no, por lo tanto con la
         * palabra clave virtual, le doy la posibilidad a los hijos de que hagan cambios sobre
         * ese atributo
         */
        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}
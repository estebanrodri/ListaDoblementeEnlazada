using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraLineal_Lista
{
    public class Nodo
    {
        private Persona Dato_Persona;
        public Nodo Nodo_Siguiente { get; set; }
        public Nodo Nodo_Anterior { get; set; }

        public Nodo(Persona Dato_Persona)
        {
            this.Dato_Persona = Dato_Persona;
            this.Nodo_Siguiente = null;
            this.Nodo_Anterior = null;
        }

        public Nodo()
        {

        }

        public void SetPersona(Persona Dato_Persona)
        {
            this.Dato_Persona = Dato_Persona;
        }

        public Persona GetPersona()
        {
            return this.Dato_Persona;
        }

    }
}

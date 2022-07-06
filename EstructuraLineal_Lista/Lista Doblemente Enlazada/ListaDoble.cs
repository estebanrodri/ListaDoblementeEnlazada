using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraLineal_Lista
{
    public class ListaDoble : ILista_TAD
    {
        private Nodo PrimerElemento;
        private Nodo UltimoElemento;
        private int CantidadDeElementos;

        public ListaDoble()
        {
            PrimerElemento = null;
            UltimoElemento = null;
            CantidadDeElementos = 0;
        }

        //Ejemplo
        //Elementos por agregar 24, 36, 40, 60
        //      Primero                                                             Ultimo                                                           
        //       Nodo1 = 24            Nodo2 = 36              Nodo3 = 40              Nodo4 = 60
        //       Nodo1.Sig = Nodo2      Nodo2.Sig = Nodo3        Nodo3.Sig = Nodo4     Nodo4.Sig = null
        //       Nodo.Anter = null      Nodo.Anterior = Nodo1   Nodo.Anterior = Nodo2  Nodo.Anterior = Nodo3

        //       primero = Nodo1          ultimo = Nodo4
        //       primero.sig = Nodo2       ultimo.sig = null 

        public void AgregarAlFinal(Nodo NuevoNodo)
        {
            if (EstaVacio())
            {
                PrimerElemento = NuevoNodo;
                PrimerElemento.Nodo_Siguiente = null;
                UltimoElemento = NuevoNodo;
            }
            else
            {

                UltimoElemento.Nodo_Siguiente = NuevoNodo;
                NuevoNodo.Nodo_Siguiente = null;
                NuevoNodo.Nodo_Anterior = UltimoElemento;
                UltimoElemento = NuevoNodo;
            }
            CantidadDeElementos++;
        }

        public void AgregarAlInicio(Nodo NuevoNodo)
        {
            if (EstaVacio())
            {
                PrimerElemento = NuevoNodo;
                PrimerElemento.Nodo_Siguiente = null;
                UltimoElemento = NuevoNodo;
            }
            else
            {
                PrimerElemento.Nodo_Anterior = NuevoNodo;
                NuevoNodo.Nodo_Siguiente = PrimerElemento;
                NuevoNodo.Nodo_Anterior = null;
                PrimerElemento = NuevoNodo;
            }
            CantidadDeElementos++;
        }

        public Persona BuscarDatoSegunIndice(int Indice)
        {
            int numeroElemento = 0;
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (numeroElemento == Indice)
                {
                    return Actual.GetPersona();
                }
                numeroElemento++;
                Actual = Actual.Nodo_Siguiente;
            }
            return null;
        }

        public Persona BuscarDatoSegunPosicion(int Posicion)
        {
            int numeroElemento = 1;
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (numeroElemento == Posicion)
                {
                    return Actual.GetPersona();
                }
                numeroElemento++;
                Actual = Actual.Nodo_Siguiente;
            }
            return null;
        }

        public int BuscarElIndiceDeUnNodo(Nodo Nodo)
        {
            int numeroElemento = 1;
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (Actual == Nodo)
                {
                    return numeroElemento - 1;
                }
                numeroElemento++;
                Actual = Actual.Nodo_Siguiente;
            }
            return -1;
        }

        public Nodo BuscarNodoSegunValor(Persona Dato_Persona)
        {
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (Actual.GetPersona().Comparar(Dato_Persona))
                {
                    return Actual;
                }
                Actual = Actual.Nodo_Siguiente;
            }
            return null;
        }

        public void EliminarNodo(Nodo Nodo)
        {
            int numeroElemento = 1;
            Nodo Actual = PrimerElemento;
            
            while (Actual != null)
            {
                if (Actual == Nodo)
                {
                    if (numeroElemento == 1)  // Primer Nodo
                    {
                        PrimerElemento = PrimerElemento.Nodo_Siguiente;
                    }
                    else if (numeroElemento == CantidadDeElementos) // Último Nodo
                    {
                        Nodo Anterior = Actual.Nodo_Anterior;
                        Anterior.Nodo_Siguiente = null;
                    }
                    else // Ni Último ni Primer Nodo
                    {
                        Nodo Siguiente = Actual.Nodo_Siguiente;  
                        Nodo Anterior = Actual.Nodo_Anterior;    
                        Anterior.Nodo_Siguiente = Siguiente;
                        Siguiente.Nodo_Anterior = Anterior;
                    }
                }
                numeroElemento++;
                Actual = Actual.Nodo_Siguiente;
            }

            CantidadDeElementos--;
        }

        public bool EstaVacio()
        {
            return CantidadDeElementos == 0;
        }

        public void LimpiarLista()
        {
            PrimerElemento.Nodo_Siguiente = null;
            UltimoElemento.Nodo_Anterior = null;
            PrimerElemento = null;
            UltimoElemento = null;
            CantidadDeElementos = 0;
        }

        public Nodo ObtenerElPrimerNodo()
        {
            return PrimerElemento;
        }

        public Nodo ObtenerElUltimoNodo()
        {
            return UltimoElemento;
        }

        public int ObtenerTamanio()
        {
            return CantidadDeElementos;
        }
    }
}

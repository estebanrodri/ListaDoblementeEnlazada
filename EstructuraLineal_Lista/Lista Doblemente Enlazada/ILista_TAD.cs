using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraLineal_Lista
{
    public interface ILista_TAD
    {
        void AgregarAlFinal(Nodo NuevoNodo);
        void AgregarAlInicio(Nodo NuevoNodo);
        int ObtenerTamanio();
        bool EstaVacio();
        void LimpiarLista();
        void EliminarNodo(Nodo Nodo);
        Nodo BuscarNodoSegunValor(Persona Dato_Persona);
        int BuscarElIndiceDeUnNodo(Nodo Nodo); 
        Nodo ObtenerElUltimoNodo();
        Nodo ObtenerElPrimerNodo();
        Persona BuscarDatoSegunPosicion(int Posicion); // 1 2
        Persona BuscarDatoSegunIndice(int Indice);// 0 1
    }
}

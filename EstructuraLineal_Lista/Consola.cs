using System;
using Estructura_Cuadrado;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraLineal_Lista
{
    public class Consola
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Estructura de un Cuadrado");
           ICuadrado EstructuraCuadrado = new Cuadrado();
           Console.WriteLine("Digite el lado del Cuadrado: ");
           double lado = Convert.ToDouble(Console.ReadLine());
           EstructuraCuadrado.EstablecerLado(lado);
           Console.WriteLine("El Área de un Cuadrado con lado "+ lado + " es: "+ EstructuraCuadrado.ObtenerElArea());
           Console.WriteLine("El Perímetro de un Cuadrado con lado " + lado + " es: " + EstructuraCuadrado.ObtenerElPerimetro());
            */

            Console.WriteLine("Estructura Lineal de una Lista Doblemente Enlazada");
           ILista_TAD ListaDoblementeEnlazada = new ListaDoble();
           // Carolina Ana Juan Everardo
           Nodo nuevoNodo1 = new Nodo(new Persona {Identificacion = "209875421", Nombre = "Juan", PrimerApellido = "Ramírez", SegundoApellido = "Villalta" });
           Nodo nuevoNodo2 = new Nodo(new Persona { Identificacion = "206467013", Nombre = "Ana", PrimerApellido = "Gonzales", SegundoApellido = "Rodríguez" });
           Nodo nuevoNodo3 = new Nodo(new Persona { Identificacion = "209675890", Nombre = "Carolina", PrimerApellido = "Ramírez", SegundoApellido = "Oreamuno" });
           Nodo nuevoNodo4 = new Nodo(new Persona { Identificacion = "208661123", Nombre = "Everardo", PrimerApellido = "Jiménez", SegundoApellido = "Valverde" });
           ListaDoblementeEnlazada.AgregarAlFinal(nuevoNodo1);
           ListaDoblementeEnlazada.AgregarAlInicio(nuevoNodo2);
           ListaDoblementeEnlazada.AgregarAlInicio(nuevoNodo3);
           ListaDoblementeEnlazada.AgregarAlFinal(nuevoNodo4);

           int CantidadLista = ListaDoblementeEnlazada.ObtenerTamanio();
           for (int i = 0; i < CantidadLista; i++)
           {
               //Console.WriteLine(ListaDoblementeEnlazada.BuscarDatoSegunPosicion(i + 1).ToString());
               Console.WriteLine(" { "+ i +" } "+ ListaDoblementeEnlazada.BuscarDatoSegunIndice(i).ToString());
           }
           Console.WriteLine("---------------------------------------------------------------------");
           Console.WriteLine("Último Nodo de la Lista:");
           Console.WriteLine(" - "+ ListaDoblementeEnlazada.ObtenerElUltimoNodo().GetPersona().ToString());

           Console.WriteLine("Primer Nodo de la Lista:");
           Console.WriteLine(" - " + ListaDoblementeEnlazada.ObtenerElPrimerNodo().GetPersona().ToString());

           Console.WriteLine("Nodo en la Posición 3:");
           Console.WriteLine(" - " + ListaDoblementeEnlazada.BuscarDatoSegunPosicion(3).ToString());

           Console.WriteLine("Índice del Nodo2:");
           Console.WriteLine(" - " + ListaDoblementeEnlazada.BuscarElIndiceDeUnNodo(nuevoNodo2).ToString());

           Console.WriteLine("¿La Lista está vacía?");
           Console.WriteLine(" - " + ListaDoblementeEnlazada.EstaVacio());

           //Persona PersonaABuscar = new Persona { Identificacion = "209675890", Nombre = "Carolina", PrimerApellido = "Ramírez", SegundoApellido = "Oreamuno" };
           Persona PersonaABuscar = nuevoNodo1.GetPersona();
           Console.WriteLine("Buscando Persona "+ PersonaABuscar.Nombre + ":");
           Nodo NodoEncontrado = ListaDoblementeEnlazada.BuscarNodoSegunValor(PersonaABuscar);
           int indice = ListaDoblementeEnlazada.BuscarElIndiceDeUnNodo(NodoEncontrado);
           Console.WriteLine(" - Encontrado: " + NodoEncontrado.GetPersona().ToString() + " En el índice: { " +indice + " }");


           Console.WriteLine("---------------------------------------------------------------------");
           Console.WriteLine("Eliminar Nodo Encontrado");
           ListaDoblementeEnlazada.EliminarNodo(NodoEncontrado);

           CantidadLista = ListaDoblementeEnlazada.ObtenerTamanio();
           for (int i = 0; i < CantidadLista; i++)
           {
               Console.WriteLine(" { " + i + " } " + ListaDoblementeEnlazada.BuscarDatoSegunIndice(i).ToString());
           }

           Console.WriteLine("---------------------------------------------------------------------");
           Console.WriteLine("Vaciar la lista");
           ListaDoblementeEnlazada.LimpiarLista();
           if (ListaDoblementeEnlazada.EstaVacio())
           {
               Console.WriteLine("Lista Vacía");
           }
           Console.WriteLine("---------------------------------------------------------------------");
           Console.WriteLine("Nueva Lista");
           // Carlos María Carolina
           Nodo nuevoNodo5 = new Nodo(new Persona { Identificacion = "109595359", Nombre = "María", PrimerApellido = "García", SegundoApellido = "Cambronero" });
           Nodo nuevoNodo6 = new Nodo(new Persona { Identificacion = "306064050", Nombre = "Carlos", PrimerApellido = "Guadamuz", SegundoApellido = "Jimenez" });
           Nodo nuevoNodo7 = new Nodo(new Persona { Identificacion = "509079032", Nombre = "Carolina", PrimerApellido = "Araya", SegundoApellido = "Calvo" });
           ListaDoblementeEnlazada.AgregarAlFinal(nuevoNodo5);
           ListaDoblementeEnlazada.AgregarAlInicio(nuevoNodo6);
           ListaDoblementeEnlazada.AgregarAlFinal(nuevoNodo7);

           CantidadLista = ListaDoblementeEnlazada.ObtenerTamanio();
           for (int i = 0; i < CantidadLista; i++)
           {
               Console.WriteLine(" { " + i + " } " + ListaDoblementeEnlazada.BuscarDatoSegunIndice(i).ToString());
           }

            Console.ReadLine();
        }
    }
}

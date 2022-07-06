using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cuadrado
{
    public class Cuadrado : ICuadrado
    {
        private double lado;

        public void EstablecerLado(double lado)
        {
            this.lado = lado;
        }

        public double ObtenerElArea()
        {
            return lado * lado; // Lado * Lado
        }

        public double ObtenerElPerimetro()
        {
            return lado *4; // Suma de todos los lados
        }
    }
}

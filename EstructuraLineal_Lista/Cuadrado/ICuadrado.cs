using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cuadrado
{
    public interface ICuadrado
    {
        void EstablecerLado(double lado);
        double ObtenerElArea();
        double ObtenerElPerimetro();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class Poligono
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }

        // Método para calcular el área de un rectángulo
        public double CalcularArea(double largo, double ancho)
        {
            return largo * ancho;
        }

       


    }
}

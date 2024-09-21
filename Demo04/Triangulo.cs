using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    public class Triangulo :Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public void CalcularArea()
        {
            Area = (Base * Altura)/2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    public class Rectangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override void CalcularArea()
        {
            Area = Base * Altura;
        }
        public override void CalcularPerimetro()
        {
            Perimetro = 2 * (Base + Altura);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    //public abstract class Poligono
    public abstract class  Poligono
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }
        //Virtual: Opcional
        public virtual void CalcularPerimetro()
        {
            Console.WriteLine("Falta implementar Perimetro");
        }
        //Abstract: Obligatorio
        public abstract void CalcularArea();
  
    }
}

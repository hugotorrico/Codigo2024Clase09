using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Profesor : Persona
    {
        public double Sueldo { get; set; }

        public void MostrarInformacionCompleta()
        {            
            Console.WriteLine(RetornarNombresCompletos());
            Console.WriteLine(Sueldo);
        }
    }
}

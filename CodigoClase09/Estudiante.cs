using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Estudiante : Persona
    {
        public string Codigo { get; set; }

        public void MostrarInformacionCompleta()
        {
            MostrarNombresCompletos();        
            
            Console.WriteLine(Codigo);
            Console.WriteLine(CalcularEdad());

        }
    }
}

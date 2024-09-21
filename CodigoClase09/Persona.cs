using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //Private:
        //Solo puedes llamarlo desde dentro de la clase
        //Protected:
        //Puedes llamarlo desde las clases hijas pero no en otra lado
        protected string RetornarNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }

        
        //Puedes llamarlo desde cualquier parte
        public void MostrarNombresCompletos()
        {
            
            Console.WriteLine(RetornarNombresCompletos());
        }

        protected int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }


    }
}

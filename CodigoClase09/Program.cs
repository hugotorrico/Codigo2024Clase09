
using CodigoClase09;

Persona persona = new Persona
{
    Apellidos = "Torrico",
    Nombres = "Hugo"
};
Console.WriteLine("Datos de la persona");

//Pública
persona.MostrarNombresCompletos();




Profesor profesor = new Profesor
{
    Apellidos = "Marquez",
    Nombres = "Felipe",
    Sueldo=5000
};

Console.WriteLine("Datos del profesor");
profesor.MostrarInformacionCompleta();

Console.Read();
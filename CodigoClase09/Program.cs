
using CodigoClase09;

Console.WriteLine("Bienvenido a CODIGO");

Persona persona = new Persona
{
    Apellidos = "Torrico",
    Nombres = "Hugo"
};
Console.WriteLine("==================");
Console.WriteLine("Datos de la persona");

//Pública
persona.MostrarNombresCompletos();

Profesor profesor = new Profesor
{
    Apellidos = "Marquez",
    Nombres = "Felipe",
    Sueldo=5000
};
Console.WriteLine("==================");
Console.WriteLine("Datos del profesor");
profesor.MostrarInformacionCompleta();


Console.WriteLine("==================");
Console.WriteLine("Datos del estudiante");
Estudiante estudiante = new Estudiante
{
    Nombres = "Brandon",
    Apellidos = "Dante",
    Codigo = "20054124",
    FechaNacimiento = Convert.ToDateTime("1988-05-04")
};

estudiante.MostrarInformacionCompleta();


Console.Read();
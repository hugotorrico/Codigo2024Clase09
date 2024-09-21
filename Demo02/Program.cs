// See https://aka.ms/new-console-template for more information

using CodigoClase09;
using CodigoClase09.Matematicas;

//Son clases públicas
Cuadrado cuadrado = new Cuadrado();
Triangulo triangulo = new Triangulo();

//Clase Internal
//No me deja usar la clase porque está en otro proyecto
//Poligono poligono = new Poligono();


cuadrado.CalcularArea();
triangulo.CalcularArea();
//poligono.CalcularArea();





Persona persona = new Persona
{
    Apellidos = "Sosa",
    Nombres = "Edson"
};
persona.MostrarNombresCompletos();

Console.WriteLine("Hello, World!");

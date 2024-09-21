

using Demo03;
//Sobrecarga
Console.WriteLine( Matematica.Sumar(5, 6));
Console.WriteLine( Matematica.Sumar(8, 9, 6));
Console.WriteLine( Matematica.Sumar(8, 9, 10));

Poligono poligono = new Poligono();
//Esto es un cuadrado
Console.WriteLine("El área del cuadrado es");
Console.WriteLine( poligono.CalcularArea(20));

//Esto es un rectangulo
Console.WriteLine("El área del rectángulo es");
Console.WriteLine( poligono.CalcularArea(20, 10));



Console.Read();

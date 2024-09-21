


using Demo04;

Cuadrado cuadrado = new Cuadrado { Lado = 10 };
Console.WriteLine("El área del cuadrado es:");
cuadrado.CalcularArea();
Console.WriteLine(cuadrado.Area);

Rectangulo rectangulo = new Rectangulo { Base = 10, Altura = 20 };
Console.WriteLine("El área del rectángulo es: ");
rectangulo.CalcularArea();
Console.WriteLine(rectangulo.Area);

Triangulo triangulo = new Triangulo { Base = 10, Altura = 20 };
Console.WriteLine("El área del triangulo es: ");
triangulo.CalcularArea();
Console.WriteLine(triangulo.Area);




using Demo04;

void SinPolimorfismo()
{
    Cuadrado cuadrado = new Cuadrado { Lado = 10 };
    Rectangulo rectangulo = new Rectangulo { Base = 10, Altura = 20 };
    Triangulo triangulo = new Triangulo { Base = 10, Altura = 20 };

    Console.WriteLine("El área del cuadrado es:");
    cuadrado.CalcularArea();
    cuadrado.CalcularPerimetro();
    Console.WriteLine(cuadrado.Area);

    Console.WriteLine("El área del rectángulo es: ");
    rectangulo.CalcularArea();
    rectangulo.CalcularPerimetro();
    Console.WriteLine(rectangulo.Area);

    Console.WriteLine("El área del triangulo es: ");
    triangulo.CalcularArea();
    triangulo.CalcularPerimetro();

    Console.WriteLine(triangulo.Area);
}


void ConPolimorfismo()
{
    //Las clases abstractas no se instancian
    //Poligono poligono = new Poligono();
    Poligono cuadrado2 = new Cuadrado { Lado = 10 };
    Poligono rectangulo2 = new Rectangulo { Base = 10, Altura = 20 };
    Poligono rectangulo3 = new Rectangulo { Base = 10, Altura = 20 };
    Poligono triangulo2 = new Triangulo { Base = 10, Altura = 20 };
    Poligono triangulo3 = new Triangulo { Base = 10, Altura = 20 };

    List<Poligono> poligonos = new List<Poligono>();
    poligonos.Add(cuadrado2);
    poligonos.Add(rectangulo2);
    poligonos.Add(rectangulo3);
    poligonos.Add(triangulo2);
    poligonos.Add(triangulo3);


    foreach (var item in poligonos)
    {
        Console.WriteLine("El área del polígono es: ");
        item.CalcularArea();
        Console.WriteLine(item.Area);
        Console.WriteLine("El perimetro del polígono es: ");
        item.CalcularPerimetro();
        Console.WriteLine(item.Perimetro);
    }

}

ConPolimorfismo();




Console.Read();
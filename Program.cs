// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aréa de un triángulo");
Console.WriteLine();

{
    
    Console.WriteLine("Ingrese la base del triángulo:");
    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese la altura del triángulo:");
    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

    double area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
    Console.WriteLine("El área del triángulo es: " + area);
}

static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
{
    double area = (baseTriangulo * alturaTriangulo) / 2;
    return area;
}
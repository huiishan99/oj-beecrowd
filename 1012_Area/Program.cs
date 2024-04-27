// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new char[] { ' ' });
double A = double.Parse(inputs[0]);
double B = double.Parse(inputs[1]);
double C = double.Parse(inputs[2]);
double Pi = 3.14159;

double areaTriangle = (A * C) / 2.0;
double areaCircle = Pi * C * C;
double areaTrapezium = (A + B) * C / 2.0;
double areaSquare = B * B;
double areaRectangle = A * B;

Console.WriteLine($"TRIANGULO: {areaTriangle:F3}");
Console.WriteLine($"CIRCULO: {areaCircle:F3}");
Console.WriteLine($"TRAPEZIO: {areaTrapezium:F3}");
Console.WriteLine($"QUADRADO: {areaSquare:F3}");
Console.WriteLine($"RETANGULO: {areaRectangle:F3}");
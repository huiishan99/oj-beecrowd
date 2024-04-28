// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
double[] sides = new double[3];
sides[0] = double.Parse(inputs[0]);
sides[1] = double.Parse(inputs[1]);
sides[2] = double.Parse(inputs[2]);

Array.Sort(sides);
Array.Reverse(sides);
double A = sides[0];
double B = sides[1];
double C = sides[2];

if (A >= (B + C))
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else
{
    double aSquare = Math.Round(A * A, 1);
    double bSquare = Math.Round(B * B, 1);
    double cSquare = Math.Round(C * C, 1);

    if (aSquare == (bSquare + cSquare))
    {
        Console.WriteLine("TRIANGULO RETANGULO");
    }

    if (aSquare > (bSquare + cSquare))
    {
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    }

    if (aSquare < (bSquare + cSquare))
    {
        Console.WriteLine("TRIANGULO ACUTANGULO");
    }

    if (A == B && B == C && C == A)
    {
        Console.WriteLine("TRIANGULO EQUILATERO");
    }

    if ((A == B && B != C) || (B == C && C != A) || (A == C && C != B))
    {
        Console.WriteLine("TRIANGULO ISOSCELES");
    }
}
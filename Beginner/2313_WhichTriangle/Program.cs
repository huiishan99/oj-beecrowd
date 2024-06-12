// See https://aka.ms/new-console-template for more information

string[] input = Console.ReadLine().Split(new[] { ' ' });
int A = int.Parse(input[0]);
int B = int.Parse(input[1]);
int C = int.Parse(input[2]);

if (A + B > C && A + C > B && B + C > A)
{
    if (A == B && B == C)
    {
        Console.WriteLine("Valido-Equilatero");
    }
    else if (A == B || B == C || A == C)
    {
        Console.WriteLine("Valido-Isoceles");
    }
    else
    {
        Console.WriteLine("Valido-Escaleno");
    }

    if (RightTriangle(A, B, C))
        Console.WriteLine("Retangulo: S");
    else
        Console.WriteLine("Retangulo: N");
}
else
{
    Console.WriteLine("Invalido");
}

static bool RightTriangle(int a, int b, int c)
{
    int[] sides = { a, b, c };
    Array.Sort(sides);
    return (sides[0] * sides[0]) + (sides[1] * sides[1]) == (sides[2] * sides[2]); // A^2 + B^2 == C^2
}
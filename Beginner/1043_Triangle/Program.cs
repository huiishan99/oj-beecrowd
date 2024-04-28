// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
double A = double.Parse(inputs[0]);
double B = double.Parse(inputs[1]);
double C = double.Parse(inputs[2]);

if (A + B > C && B + C > A && A + C > B)
{
    double perimeter = A + B + C;
    Console.WriteLine("Perimetro = {0:F1}", perimeter);
}
else
{
    double area = (C * (A + B)) / 2.0;
    Console.WriteLine("Area = {0:F1}", area);
}
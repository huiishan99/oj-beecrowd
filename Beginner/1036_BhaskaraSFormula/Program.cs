// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new char[] { ' ' });
double A = double.Parse(inputs[0]);
double B = double.Parse(inputs[1]);
double C = double.Parse(inputs[2]);

double delta = (B * B) - (4 * A * C);

if (A == 0 || delta < 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
    double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

    Console.WriteLine("R1 = {0:F5}", R1);
    Console.WriteLine("R2 = {0:F5}", R2);
}
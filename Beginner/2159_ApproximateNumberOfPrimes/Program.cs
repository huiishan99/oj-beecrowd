// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

double p = n / Math.Log(n);
double m = 1.25506 * n / Math.Log(n);

Console.WriteLine("{0:F1} {1:F1}", p, m);
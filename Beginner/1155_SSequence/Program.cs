// See https://aka.ms/new-console-template for more information

double S = 0;

for (int i = 1; i <= 100; i++)
{
    S = S + 1.0 / i;
}

Console.WriteLine("{0:F2}", S);
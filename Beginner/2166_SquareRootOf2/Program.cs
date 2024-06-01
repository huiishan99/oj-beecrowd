// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

double[] root = new double[n + 1];
root[0] = 0;

for (int i = 1; i <= n; i++)
{
    root[i] = 1 / (2 + root[i - 1]);
}

Console.WriteLine("{0:F10}", 1.0 + root[n]);
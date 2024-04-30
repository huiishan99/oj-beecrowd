// See https://aka.ms/new-console-template for more information

double[] A = new double[100];

for (int i = 0; i < 100; i++)
{
    double input = double.Parse(Console.ReadLine());
    A[i] = input;
}

for (int i = 0; i < 100; i++)
{
    if (A[i] <= 10)
    {
        Console.WriteLine("A[{0}] = {1:F1}", i, A[i]);
    }
}
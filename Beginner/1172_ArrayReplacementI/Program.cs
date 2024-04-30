// See https://aka.ms/new-console-template for more information

int[] X = new int[10];

for (int i = 0; i < 10; i++)
{
    X[i] = int.Parse(Console.ReadLine());
    if (X[i] <= 0)
    {
        X[i] = 1;
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("X[{0}] = {1}", i, X[i]);
}
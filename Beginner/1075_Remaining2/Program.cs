// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10000; i++)
{
    if (i % N == 2)
    {
        Console.WriteLine(i);
    }
}
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    if (i == N - 1)
    {
        Console.WriteLine("Ho!");
    }
    else
    {
        Console.Write("Ho ");
    }
}
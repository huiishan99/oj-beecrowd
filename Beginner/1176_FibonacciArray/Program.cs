// See https://aka.ms/new-console-template for more information

ulong[] fibonacci = new ulong[61];
fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i <= 60; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Fib({0}) = {1}", N, fibonacci[N]);
}
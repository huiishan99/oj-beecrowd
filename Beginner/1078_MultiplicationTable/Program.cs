// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", i, N, i * N);
}
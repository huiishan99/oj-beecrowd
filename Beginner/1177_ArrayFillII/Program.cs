// See https://aka.ms/new-console-template for more information

int T = int.Parse(Console.ReadLine());
int[] N = new int[1000];

for (int i = 0; i < 1000; i++)
{
    N[i] = i % T;
}

for (int i = 0; i < 1000; i++)
{
    Console.WriteLine("N[{0}] = {1}", i, N[i]);
}
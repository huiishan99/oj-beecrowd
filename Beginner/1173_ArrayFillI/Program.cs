// See https://aka.ms/new-console-template for more information

int[] N = new int[10];

int V = int.Parse(Console.ReadLine());

N[0] = V;
Console.WriteLine("N[0] = {0}", V);

for (int i = 1; i < 10; i++)
{
    N[i] = N[i - 1] * 2;
    Console.WriteLine("N[{0}] = {1}", i, N[i]);
}
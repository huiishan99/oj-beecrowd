// See https://aka.ms/new-console-template for more information

int[] N = new int[20];

for (int i = 0; i < 20; i++)
{
    int input = int.Parse(Console.ReadLine());
    N[i] = input;
}

Array.Reverse(N);

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("N[{0}] = {1}", i, N[i]);
}
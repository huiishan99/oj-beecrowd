// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

int min = Math.Min(X, Y);
int max = Math.Max(X, Y);

for (int i = min + 1; i <= max - 1; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}
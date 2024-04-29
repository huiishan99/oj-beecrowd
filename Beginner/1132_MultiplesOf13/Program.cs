// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

int min = Math.Min(X, Y);
int max = Math.Max(X, Y);
int sum = 0;

for (int i = min; i <= max; i++)
{
    if (i % 13 != 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);
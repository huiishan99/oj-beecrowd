// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int sumOddNumbers = 0;

int start = Math.Min(X, Y);
int end = Math.Max(X, Y);

for (int i = start + 1; i < end; i++)
{
    if (i % 2 != 0)
    {
        sumOddNumbers = sumOddNumbers + i;
    }
}

Console.WriteLine(sumOddNumbers);
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
int inInterval = 0;
int outOfInterval = 0;

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    if ((X >= 10) && (X <= 20))
    {
        inInterval++;
    }
    else
    {
        outOfInterval++;
    }
}

Console.WriteLine("{0} in", inInterval);
Console.WriteLine("{0} out", outOfInterval);
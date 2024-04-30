// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    int count = 0;
    for (int j = 1; j < X; j++)
    {
        count = j;
        if (j > 1 && X % j == 0)
        {
            Console.WriteLine("{0} nao eh primo", X);
            break;
        }
    }

    count = count + 1;
    if (X == count && X % count == 0)
    {
        Console.WriteLine("{0} eh primo", X);
    }
}
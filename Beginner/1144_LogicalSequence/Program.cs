// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
int square = 0;
int cube = 0;

for (int i = 1; i <= N; i++)
{
    for (int j = 1; j <= 2; j++)
    {
        square = i * i;
        cube = square * i;

        if (j == 2)
        {
            Console.WriteLine("{0} {1} {2}", i, square + 1, cube + 1);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", i, square, cube);
        }
    }
}
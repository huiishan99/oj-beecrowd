// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
int square = 0;
int cube = 0;

for (int i = 1; i <= N; i++)
{
    square = i * i;
    cube = square * i;
    Console.WriteLine("{0} {1} {2}", i, square, cube);
}
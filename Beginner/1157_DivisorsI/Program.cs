// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());
int N = input;
int divisor = 1;

while (divisor <= N)
{
    if (N % divisor == 0)
    {
        Console.WriteLine(divisor);
    }

    divisor++;
}
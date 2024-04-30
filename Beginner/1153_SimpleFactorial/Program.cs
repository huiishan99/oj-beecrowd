// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());
int N = input;
int factorial = N;

for (int i = 1; i <= N - 1; i++)
{
    factorial = factorial * (N - i);
}

Console.WriteLine(factorial);
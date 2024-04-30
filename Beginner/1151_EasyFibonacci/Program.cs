// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());
int N = input;
int firstNumber = 0;
int secondNumber = 1;
int thirdNumber;

for (int i = 1; i <= N; i++)
{
    if (i == N)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.Write("{0} ", firstNumber);
        thirdNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = thirdNumber;
    }
}
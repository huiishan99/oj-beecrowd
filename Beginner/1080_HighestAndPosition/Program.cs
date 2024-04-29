// See https://aka.ms/new-console-template for more information

int max = 0;
int inputPosition = 0;

for (int i = 1; i <= 100; i++)
{
    int input = int.Parse(Console.ReadLine());
    if (input > max)
    {
        max = input;
        inputPosition = i;
    }
}

Console.WriteLine(max);
Console.WriteLine(inputPosition);
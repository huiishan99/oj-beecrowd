// See https://aka.ms/new-console-template for more information

int evenNumbers = 0;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        evenNumbers++;
    }
}

Console.WriteLine("{0} valores pares", evenNumbers);
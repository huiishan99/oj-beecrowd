// See https://aka.ms/new-console-template for more information

int evenNumbers = 0;
int oddNumbers = 0;
int positiveNumbers = 0;
int negativeNumbers = 0;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0)
    {
        evenNumbers++;
    }

    if (number % 2 != 0)
    {
        oddNumbers++;
    }

    if (number > 0)
    {
        positiveNumbers++;
    }

    if (number < 0)
    {
        negativeNumbers++;
    }
}

Console.WriteLine("{0} valor(es) par(es)", evenNumbers);
Console.WriteLine("{0} valor(es) impar(es)", oddNumbers);
Console.WriteLine("{0} valor(es) positivo(s)", positiveNumbers);
Console.WriteLine("{0} valor(es) negativo(s)", negativeNumbers);
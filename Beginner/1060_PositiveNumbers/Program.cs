// See https://aka.ms/new-console-template for more information

int positiveNumbers = 0;

for (int i = 0; i < 6; i++)
{
    double number = double.Parse(Console.ReadLine());
    if (number > 0)
    {
        positiveNumbers++;
    }
}

Console.WriteLine("{0} valores positivos", positiveNumbers);
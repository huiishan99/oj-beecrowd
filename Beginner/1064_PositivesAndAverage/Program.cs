// See https://aka.ms/new-console-template for more information

int positiveNumbers = 0;
double positiveSum = 0;

for (int i = 0; i < 6; i++)
{
    double number = double.Parse(Console.ReadLine());
    if (number > 0)
    {
        positiveNumbers++;
        positiveSum = positiveSum + number;
    }
}

double average = positiveSum / positiveNumbers;

Console.WriteLine("{0} valores positivos", positiveNumbers);
Console.WriteLine("{0:F1}", average);
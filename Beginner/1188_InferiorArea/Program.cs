// See https://aka.ms/new-console-template for more information

char O = char.Parse(Console.ReadLine());
double[,] M = new double[12, 12];

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        M[i, j] = double.Parse(Console.ReadLine());
    }
}

double sum = 0;
int startNumber = 1;
int endNumber = 11;
int averageCount = 0;

for (int i = 11; i > 6; i--)
{
    for (int j = startNumber; j < endNumber; j++)
    {
        sum = sum + M[i, j];
        averageCount++;
    }

    startNumber++;
    endNumber--;
}

if (O == 'S')
{
    Console.WriteLine("{0:F1}", sum);
}
else
{
    double average = sum / averageCount;
    Console.WriteLine("{0:F1}", average);
}
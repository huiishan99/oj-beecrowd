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
int count = 0;

for (int i = 1; i < 12; i++)
{
    for (int j = 0; j < i; j++)
    {
        sum = sum + M[i, j];
        count++;
    }
}

if (O == 'S')
{
    Console.WriteLine("{0:F1}", sum);
}
else
{
    double average = sum / count;
    Console.WriteLine("{0:F1}", average);
}
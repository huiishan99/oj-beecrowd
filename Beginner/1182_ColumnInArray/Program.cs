// See https://aka.ms/new-console-template for more information

int C = int.Parse(Console.ReadLine());
char T = char.Parse(Console.ReadLine());
double[,] M = new double[12, 12];

for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        M[i, j] = double.Parse(Console.ReadLine());
    }
}

double sum = 0;
double average = 0;
for (int i = 0; i < 12; i++)
{
    sum = sum + M[i, C];
}

if (T == 'S')
{
    Console.WriteLine("{0:F1}", sum);
}
else
{
    average = sum / 12;
    Console.WriteLine("{0:F1}", average);
}
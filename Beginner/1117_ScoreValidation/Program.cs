// See https://aka.ms/new-console-template for more information

double sum = 0;

for (int i = 0; i < 2; i++)
{
    double score = double.Parse(Console.ReadLine());
    if (score < 0 || score > 10)
    {
        Console.WriteLine("nota invalida");
        i--;
    }
    else
    {
        sum = sum + score;
        if (i == 1)
        {
            double average = sum / 2.0;
            Console.WriteLine("media = {0:F2}", average);
        }
    }
}
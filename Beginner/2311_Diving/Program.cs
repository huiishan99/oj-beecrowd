// See https://aka.ms/new-console-template for more information

int number = int.Parse(Console.ReadLine());
string[] name = new string[number];
double[] totalScore = new double[number];

for (int i = 0; i < number; i++)
{
    name[i] = Console.ReadLine();
    double difficulty = double.Parse(Console.ReadLine());
    string[] scoreInput = Console.ReadLine().Split(new[] { ' ' });

    double[] scores = new double[7];
    for (int j = 0; j < 7; j++)
    {
        scores[j] = double.Parse(scoreInput[j]);
    }

    Array.Sort(scores);

    totalScore[i] = 0;
    for (int j = 1; j < 6; j++)
    {
        totalScore[i] += scores[j];
    }

    totalScore[i] *= difficulty;
    Console.WriteLine($"{name[i]} {totalScore[i]:F2}");
}
// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());
int highestScoreStudent = 0;
double highestScore = 0;

for (int i = 0; i < testCases; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int studentNumber = int.Parse(inputs[0]);
    double studentNote = double.Parse(inputs[1]);

    if (studentNote >= 8 && studentNote > highestScore)
    {
        highestScoreStudent = studentNumber;
        highestScore = studentNote;
    }
}

if (highestScoreStudent != 0)
{
    Console.WriteLine(highestScoreStudent);
}
else
{
    Console.WriteLine("Minimum note not reached");
}
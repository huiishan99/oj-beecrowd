// See https://aka.ms/new-console-template for more information

int teaType = int.Parse(Console.ReadLine());

string[] guessTypes = Console.ReadLine().Split(new[] { ' ' });

int correct = 0;
for (int i = 0; i < 5; i++)
{
    if (int.Parse(guessTypes[i]) == teaType)
    {
        correct++;
    }
}

Console.WriteLine(correct);
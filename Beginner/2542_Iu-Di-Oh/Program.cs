// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    int N = int.Parse(input);

    string[] secondLine = Console.ReadLine().Split(new[] { ' ' });
    int M = int.Parse(secondLine[0]);
    int L = int.Parse(secondLine[1]);

    int[,] marcosCard = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        string[] marcosInput = Console.ReadLine().Split(new[] { ' ' });
        for (int j = 0; j < N; j++)
        {
            marcosCard[i, j] = int.Parse(marcosInput[j]);
        }
    }

    int[,] leonardoCard = new int[L, N];
    for (int i = 0; i < L; i++)
    {
        string[] leonardoInput = Console.ReadLine().Split(new[] { ' ' });
        for (int j = 0; j < N; j++)
        {
            leonardoCard[i, j] = int.Parse(leonardoInput[j]);
        }
    }

    string[] choseInput = Console.ReadLine().Split(new[] { ' ' });
    int marcosChoose = int.Parse(choseInput[0]) - 1;
    int leonardoChoose = int.Parse(choseInput[1]) - 1;

    int chosenAtt = int.Parse(Console.ReadLine()) - 1;

    if (marcosCard[marcosChoose, chosenAtt] > leonardoCard[leonardoChoose, chosenAtt])
    {
        Console.WriteLine("Marcos");
    }
    else if (marcosCard[marcosChoose, chosenAtt] < leonardoCard[leonardoChoose, chosenAtt])
    {
        Console.WriteLine("Leonardo");
    }
    else
    {
        Console.WriteLine("Empate");
    }
}
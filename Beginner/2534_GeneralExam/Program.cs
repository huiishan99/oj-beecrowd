// See https://aka.ms/new-console-template for more information

string line;
while ((line = Console.ReadLine()) != null)
{
    string[] testCase = line.Split(new[] { ' ' });
    int citizenNum = int.Parse(testCase[0]);
    int querieNum = int.Parse(testCase[1]);

    int[] citizenGrade = new int[citizenNum];
    for (int i = 0; i < citizenNum; i++)
    {
        citizenGrade[i] = int.Parse(Console.ReadLine());
        Array.Sort(citizenGrade);
        Array.Reverse(citizenGrade);
    }

    int positionCheck;
    for (int i = 0; i < querieNum; i++)
    {
        positionCheck = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine(citizenGrade[positionCheck]);
    }
}
// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

string input;

while ((input = Console.ReadLine()) != null)
{
    int number = int.Parse(input);

    int[,] exp = new int[number, 3];
    for (int i = 0; i < number; i++)
    {
        string[] testCase = Console.ReadLine().Split(new[] { ' ', '=' });
        int X = int.Parse(testCase[0]);
        int Y = int.Parse(testCase[1]);
        int Z = int.Parse(testCase[2]); // X (+-*) Y = Z

        exp[i, 0] = X;
        exp[i, 1] = Y;
        exp[i, 2] = Z;
    }

    string[] nameByExp = new string[number];
    bool[] trueAns = new bool[number];
    int truePlayerNumber = 0;
    for (int i = 0; i < number; i++)
    {
        string[] playerSelect = Console.ReadLine().Split(new[] { ' ' });
        string name = playerSelect[0];
        int selectExp = int.Parse(playerSelect[1]) - 1;
        string operate = playerSelect[2];

        nameByExp[selectExp] = name;

        if (operate == "+")
        {
            trueAns[selectExp] = exp[selectExp, 0] + exp[selectExp, 1] == exp[selectExp, 2];
        }
        else if (operate == "-")
        {
            trueAns[selectExp] = exp[selectExp, 0] - exp[selectExp, 1] == exp[selectExp, 2];
        }
        else if (operate == "*")
        {
            trueAns[selectExp] = exp[selectExp, 0] * exp[selectExp, 1] == exp[selectExp, 2];
        }
        else
        {
            trueAns[selectExp] = exp[selectExp, 0] + exp[selectExp, 1] != exp[selectExp, 2] &&
                                 exp[selectExp, 0] - exp[selectExp, 1] != exp[selectExp, 2] &&
                                 exp[selectExp, 0] * exp[selectExp, 1] != exp[selectExp, 2];
        }

        if (trueAns[selectExp])
        {
            truePlayerNumber++;
        }
    }

    List<string> wrongPlayers = new List<string>();

    if (truePlayerNumber == number)
    {
        Console.WriteLine("You Shall All Pass!");
    }
    else if (truePlayerNumber == 0)
    {
        Console.WriteLine("None Shall Pass!");
    }
    else
    {
        for (int i = 0; i < number; i++)
        {
            if (trueAns[i] == false)
            {
                wrongPlayers.Add(nameByExp[i]);
            }
        }

        // 在 beecrowd 常规的 wrongPlayers.Sort 会导致排序答案不准确
        wrongPlayers.Sort((x, y) => String.CompareOrdinal(x, y));

        Console.WriteLine(string.Join(" ", wrongPlayers));
    }
}
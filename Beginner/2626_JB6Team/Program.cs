// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, string> rule = new Dictionary<string, string>
{
    ["pedra"] = "tesoura",
    ["tesoura"] = "papel",
    ["papel"] = "pedra",
};

Dictionary<int, string> winner = new Dictionary<int, string>
{
    [0] = "Os atributos dos monstros vao ser inteligencia, sabedoria...",
    [1] = "Iron Maiden's gonna get you, no matter how far!",
    [2] = "Urano perdeu algo muito precioso..."
};

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] play = line.Split(new[] { ' ' });
    string dodo = play[0];
    string leo = play[1];
    string pepper = play[2];
    string[] playerChoose = new string[2];

    int countSame = 0;
    if (dodo == leo)
    {
        countSame++;
        playerChoose[0] = dodo;
        playerChoose[1] = pepper;
    }

    if (leo == pepper)
    {
        countSame++;
        playerChoose[0] = leo;
        playerChoose[1] = dodo;
    }

    if (pepper == dodo)
    {
        countSame++;
        playerChoose[0] = pepper;
        playerChoose[1] = leo;
    }

    if (countSame == 0 || countSame == 3)
    {
        Console.WriteLine("Putz vei, o Leo ta demorando muito pra jogar...");
    }
    else if (countSame == 1)
    {
        if (rule[playerChoose[1]] == playerChoose[0])
        {
            for (int i = 0; i < 3; i++)
            {
                if (playerChoose[1] == play[i])
                {
                    string output = winner[i];
                    Console.WriteLine(output);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Putz vei, o Leo ta demorando muito pra jogar...");
        }
    }
}
// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, List<string>> rockPaperScissorsLizardSpock = new Dictionary<string, List<string>>
{
    ["tesoura"] = new List<string> { "papel", "lagarto" },
    ["papel"] = new List<string> { "pedra", "Spock" },
    ["pedra"] = new List<string> { "lagarto", "tesoura" },
    ["lagarto"] = new List<string> { "Spock", "papel" },
    ["Spock"] = new List<string> { "tesoura", "pedra" }
};

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    string sheldon = inputs[0];
    string raj = inputs[1];

    if (sheldon == raj)
    {
        Console.WriteLine("Caso #{0}: De novo!", i + 1);
    }
    else if (rockPaperScissorsLizardSpock[sheldon].Contains(raj))
    {
        Console.WriteLine("Caso #{0}: Bazinga!", i + 1);
    }
    else
    {
        Console.WriteLine("Caso #{0}: Raj trapaceou!", i + 1);
    }
}
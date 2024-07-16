// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Text.RegularExpressions;

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    if (i > 0)
    {
        Console.WriteLine();
    }

    int T = int.Parse(Console.ReadLine());
    List<string> dangerousCompounds = new List<string>();

    for (int j = 0; j < T; j++)
    {
        dangerousCompounds.Add(Console.ReadLine());
    }

    int U = int.Parse(Console.ReadLine());
    List<string> experiments = new List<string>();

    for (int j = 0; j < U; j++)
    {
        experiments.Add(Console.ReadLine());
    }

    foreach (var experiment in experiments)
    {
        bool isDangerous = false;
        foreach (var compound in dangerousCompounds)
        {
            if (IsCompoundPresent(experiment, compound))
            {
                isDangerous = true;
                break;
            }
        }

        if (isDangerous)
        {
            Console.WriteLine("Abortar");
        }
        else
        {
            Console.WriteLine("Prossiga");
        }
    }
}

static bool IsCompoundPresent(string experiment, string compound)
{
    // 使用正则表达式来匹配完整的化学物
    string pattern = $@"\b{Regex.Escape(compound)}\b";
    return Regex.IsMatch(experiment, pattern);
}
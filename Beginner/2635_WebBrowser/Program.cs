// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;

string input;
while ((input = Console.ReadLine()) != null)
{
    int N = int.Parse(input);
    List<string> searchedWords = new List<string>();

    for (int i = 0; i < N; i++)
    {
        searchedWords.Add(Console.ReadLine());
    }

    int Q = int.Parse(Console.ReadLine());
    List<string> queries = new List<string>();

    for (int i = 0; i < Q; i++)
    {
        queries.Add(Console.ReadLine());
    }

    foreach (var query in queries)
    {
        var suggestions = searchedWords.Where(word => word.StartsWith(query)).ToList();

        if (suggestions.Count > 0)
        {
            int maxLength = suggestions.Max(word => word.Length);
            Console.WriteLine($"{suggestions.Count} {maxLength}");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}
// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

HashSet<string> uniqueJewels = new HashSet<string>();
string input;

while ((input = Console.ReadLine()) != null)
{
    uniqueJewels.Add(input);
}

Console.WriteLine(uniqueJewels.Count);
// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;

int N = int.Parse(Console.ReadLine());

int K = int.Parse(Console.ReadLine());

List<int> scores = new List<int>();
for (int i = 0; i < N; i++)
{
    scores.Add(int.Parse(Console.ReadLine()));
}

scores.Sort((a, b) => b.CompareTo(a));

int thresholdScore = scores[K - 1];

int qualifiers = scores.Count(score => score >= thresholdScore);

Console.WriteLine(qualifiers);
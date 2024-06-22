// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;

while (true)
{
    try
    {
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) break;

        int n = int.Parse(line);

        line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) break;

        List<int> assignments =
            line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        if (assignments.Count != n) break;

        long totalSum = assignments.Sum(x => (long)x);

        long halfSum = 0;
        long minDifference = totalSum;

        for (int i = 0; i < assignments.Count; i++)
        {
            halfSum += assignments[i];
            long remainingSum = totalSum - halfSum;
            long difference = Math.Abs(halfSum - remainingSum);
            minDifference = Math.Min(minDifference, difference);
        }

        Console.WriteLine(minDifference);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        break;
    }
}
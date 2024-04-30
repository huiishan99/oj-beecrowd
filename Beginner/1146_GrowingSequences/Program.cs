// See https://aka.ms/new-console-template for more information

using System.Linq;

while (true)
{
    int input = int.Parse(Console.ReadLine());
    if (input == 0) break;

    Console.WriteLine(string.Join(" ", Enumerable.Range(1, input)));
}
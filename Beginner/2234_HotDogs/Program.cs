// See https://aka.ms/new-console-template for more information

string[] input = Console.ReadLine().Split(new[] { ' ' });
int hotDogs = int.Parse(input[0]);
int participants = int.Parse(input[1]);

double result = hotDogs * 1.0 / participants;

Console.WriteLine($"{result:F2}");
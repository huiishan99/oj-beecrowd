// See https://aka.ms/new-console-template for more information

string[] reindeersList = { "Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen", "Rudolph" };
string[] input = Console.ReadLine().Split(new[] { ' ' });

int sum = 0;
for (int i = 0; i < 9; i++)
{
    int X = int.Parse(input[i]);
    sum += X;
}

int winReindeerNum = (sum - 1) % 9;
Console.WriteLine(reindeersList[winReindeerNum]);
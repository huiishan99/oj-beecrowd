// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    int testNum = int.Parse(input);

    int timesUsed = (int)(Math.Log(testNum) / Math.Log(2));

    Console.WriteLine(timesUsed);
}
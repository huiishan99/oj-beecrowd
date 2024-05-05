// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int radius1 = int.Parse(inputs[0]);
    int radius2 = int.Parse(inputs[1]);

    int smallestRadius = radius1 + radius2;
    Console.WriteLine(smallestRadius);
}
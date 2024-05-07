// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    string name1 = inputs[0];
    string firstPersonChoice = inputs[1];
    string name2 = inputs[2];
    string secondPersonChoice = inputs[3];

    Dictionary<int, string> parImpar = new Dictionary<int, string>
    {
        [1] = name1, [2] = name2
    };

    string[] inputNumbers = Console.ReadLine().Split(new[] { ' ' });
    int number1 = int.Parse(inputNumbers[0]);
    int number2 = int.Parse(inputNumbers[1]);

    if ((number1 + number2) % 2 == 0)
    {
        if (firstPersonChoice == "PAR") Console.WriteLine(parImpar[1]);
        else Console.WriteLine(parImpar[2]);
    }
    else
    {
        if (firstPersonChoice == "PAR") Console.WriteLine(parImpar[2]);
        else Console.WriteLine(parImpar[1]);
    }
}
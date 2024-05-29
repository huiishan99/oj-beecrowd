// See https://aka.ms/new-console-template for more information

int caseNumber = 0;
string input;

while ((input = Console.ReadLine()) != null)
{
    string wholeSub = Console.ReadLine();

    int count = 0;
    int position = 0;
    int lastIndex = 0;
    while ((position = wholeSub.IndexOf(input, position)) != -1)
    {
        lastIndex = position;
        position++;
        count++;
    }

    caseNumber++;
    Console.WriteLine("Caso #{0}:", caseNumber);

    if (count == 0)
    {
        Console.WriteLine("Nao existe subsequencia");
    }
    else
    {
        Console.WriteLine("Qtd.Subsequencias: {0}", count);
        Console.WriteLine("Pos: {0}", lastIndex + 1);
    }

    Console.WriteLine();
}
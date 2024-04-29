// See https://aka.ms/new-console-template for more information

while (true)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int X = int.Parse(inputs[0]);
    int Y = int.Parse(inputs[1]);

    if (X == Y) break;

    if (X > Y)
    {
        Console.WriteLine("Decrescente");
    }
    else
    {
        Console.WriteLine("Crescente");
    }
}
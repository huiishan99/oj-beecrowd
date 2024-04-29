// See https://aka.ms/new-console-template for more information

while (true)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int X = int.Parse(inputs[0]);
    int Y = int.Parse(inputs[1]);

    if (X == 0 || Y == 0) break;

    if (X > 0)
    {
        if (Y > 0)
        {
            Console.WriteLine("primeiro");
        }
        else
        {
            Console.WriteLine("quarto");
        }
    }
    else
    {
        if (Y > 0)
        {
            Console.WriteLine("segundo");
        }
        else
        {
            Console.WriteLine("terceiro");
        }
    }
}
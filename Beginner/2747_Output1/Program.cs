// See https://aka.ms/new-console-template for more information

for (int i = 0; i < 39; i++)
{
    Console.Write("-");
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 39; j++)
    {
        if (j == 0 || j == 38)
        {
            Console.Write("|");
        }
        else
        {
            Console.Write(" ");
        }
    }

    Console.WriteLine();
}

for (int i = 0; i < 39; i++)
{
    Console.Write("-");
}

Console.WriteLine();
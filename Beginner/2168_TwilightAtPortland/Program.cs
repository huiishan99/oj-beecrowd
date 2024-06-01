// See https://aka.ms/new-console-template for more information

int number = int.Parse(Console.ReadLine());
int[,] block = new int[number + 1, number + 1];

for (int i = 0; i < number + 1; i++)
{
    string[] input = Console.ReadLine().Split(new[] { ' ' });
    for (int j = 0; j < number + 1; j++)
    {
        block[i, j] = int.Parse(input[j]);
    }
}

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        if (block[i, j] + block[i, j + 1] + block[i + 1, j] + block[i + 1, j + 1] >= 2)
            Console.Write("S");
        else
            Console.Write("U");
    }

    Console.WriteLine();
}
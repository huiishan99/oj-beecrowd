// See https://aka.ms/new-console-template for more information

int numbers = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers; i++)
{
    int bonus = int.Parse(Console.ReadLine());
    int[] attackValue = new int[2];
    int[] defendValue = new int[2];
    int[] level = new int [2];
    int[] totalValue = new int[2];
    for (int j = 0; j < 2; j++)
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' });
        attackValue[j] = int.Parse(input[0]);
        defendValue[j] = int.Parse(input[1]);
        level[j] = int.Parse(input[2]);

        totalValue[j] = (attackValue[j] + defendValue[j]) / 2;
        if (level[j] % 2 == 0) totalValue[j] += bonus;
    }

    if (totalValue[0] == totalValue[1])
        Console.WriteLine("Empate");
    else if (totalValue[0] > totalValue[1])
        Console.WriteLine("Dabriel");
    else
        Console.WriteLine("Guarte");
}
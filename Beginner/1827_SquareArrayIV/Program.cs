// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    int n = int.Parse(line);
    int[,] matrix = new int[n, n];

    int central = n / 2;
    int innerStart = n / 3;
    int innerEnd = n - innerStart;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j) matrix[i, j] = 2;
            if (i + j == n - 1) matrix[i, j] = 3;
            if (i >= innerStart && i < innerEnd && j >= innerStart && j < innerEnd) matrix[i, j] = 1;
        }
    }

    matrix[central, central] = 4;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j]);
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
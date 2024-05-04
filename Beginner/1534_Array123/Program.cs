// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    int N = int.Parse(input);
    int[,] M = new int[N, N];

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (i + j == N - 1)
            {
                M[i, j] = 2;
            }
            else if (i == j)
            {
                M[i, j] = 1;
            }
            else
            {
                M[i, j] = 3;
            }
        }
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write(M[i, j]);
        }

        Console.WriteLine();
    }
}
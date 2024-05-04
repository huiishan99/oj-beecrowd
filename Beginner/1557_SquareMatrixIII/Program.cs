// See https://aka.ms/new-console-template for more information

while (true)
{
    int N = int.Parse(Console.ReadLine());
    if (N == 0) break;

    int[,] M = new int[N, N];

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (i == 0 && j == 0)
            {
                M[0, 0] = 1;
            }
            else if (j == 0)
            {
                M[i, j] = M[i - 1, 0] * 2;
            }
            else
            {
                M[i, j] = M[i, j - 1] * 2;
            }
        }
    }

    int maxLength = M[N - 1, N - 1].ToString().Length;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (j == N - 1)
            {
                Console.Write(M[i, j].ToString().PadLeft(maxLength));
            }
            else
            {
                Console.Write(M[i, j].ToString().PadLeft(maxLength) + " ");
            }
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
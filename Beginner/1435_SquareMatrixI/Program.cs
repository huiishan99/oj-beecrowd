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
            int min = Math.Min(Math.Min(i, j), Math.Min(N - i - 1, N - j - 1));
            M[i, j] = min + 1;
        }
    }

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            if (j == N - 1)
            {
                Console.Write("{0,3}", M[i, j]);
            }
            else
            {
                Console.Write("{0,3}", M[i, j]);
            }
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
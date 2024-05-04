// See https://aka.ms/new-console-template for more information

while (true)
{
    int N = int.Parse(Console.ReadLine());
    if (N == 0) break;

    int[,] M = new int[N, N];

    for (int i = 0; i < N; i++)
    {
        int sequence = 1;
        int reverse = i + 1;
        for (int j = 0; j < N; j++)
        {
            if (j >= i)
            {
                M[i, j] = sequence;
                sequence++;
            }
            else
            {
                M[i, j] = reverse;
                reverse--;
            }
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
                Console.Write("{0,3} ", M[i, j]);
            }
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
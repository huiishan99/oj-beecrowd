// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] board = line.Split(new[] { ' ' });
    int n = int.Parse(board[0]);
    int m = int.Parse(board[1]);
    int[,] cheeseBoard = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        string[] boardInput = Console.ReadLine().Split(new[] { ' ' });
        for (int j = 0; j < m; j++)
        {
            cheeseBoard[i, j] = int.Parse(boardInput[j]);
        }
    }

    int[,] output = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (cheeseBoard[i, j] == 1)
            {
                output[i, j] = 9;
                Console.Write(output[i, j]);
            }
            else
            {
                int count = 0;
                if (i != 0)
                {
                    if (cheeseBoard[i - 1, j] == 1) count++;
                }

                if (j != 0)
                {
                    if (cheeseBoard[i, j - 1] == 1) count++;
                }

                if (j != m - 1)
                {
                    if (cheeseBoard[i, j + 1] == 1) count++;
                }

                if (i != n - 1)
                {
                    if (cheeseBoard[i + 1, j] == 1) count++;
                }


                output[i, j] = count;
                Console.Write(output[i, j]);
            }
        }

        Console.WriteLine();
    }
}
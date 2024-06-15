// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    string[] firstLine = input.Split(new[] { ' ' });
    int row = int.Parse(firstLine[0]);
    int column = int.Parse(firstLine[1]);

    int[,] matrix = new int[row, column];
    int count = 0;
    int targetI = 0;
    int targetJ = 0;
    int startI = 0;
    int startJ = 0;
    bool setTarget = false;
    bool setStart = false;

    for (int i = 0; i < row; i++)
    {
        string[] integer = Console.ReadLine().Split(new[] { ' ' });
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = int.Parse(integer[j]);

            if (matrix[i, j] == 2)
            {
                targetI = i;
                targetJ = j;
                setTarget = true;
            }

            if (matrix[i, j] == 1)
            {
                startI = i;
                startJ = j;
                setStart = true;
            }
        }
    }

    if (setStart && setTarget)
    {
        count = Math.Abs(targetI - startI) + Math.Abs(targetJ - startJ);
        Console.WriteLine(count);
    }
}
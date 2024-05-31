// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int row = int.Parse(inputs[0]);
int column = int.Parse(inputs[1]);

int[,] matrix = new int[row, column];

for (int i = 0; i < row; i++)
{
    string[] rowInputs = Console.ReadLine().Split(new[] { ' ' });
    for (int j = 0; j < column; j++)
    {
        matrix[i, j] = int.Parse(rowInputs[j]);
    }
}

bool lightsaberFound = false;

for (int i = 1; i < row - 1; i++)
{
    for (int j = 1; j < column - 1; j++)
    {
        if (matrix[i, j] == 42 &&
            matrix[i - 1, j - 1] == 7 && matrix[i - 1, j] == 7 && matrix[i - 1, j + 1] == 7 &&
            matrix[i, j - 1] == 7 && matrix[i, j + 1] == 7 &&
            matrix[i + 1, j - 1] == 7 && matrix[i + 1, j] == 7 && matrix[i + 1, j + 1] == 7)
        {
            Console.WriteLine("{0} {1}", i + 1, j + 1);
            lightsaberFound = true;
            break;
        }
    }

    if (lightsaberFound)
    {
        break;
    }
}

if (lightsaberFound == false)
{
    Console.WriteLine("0 0");
}
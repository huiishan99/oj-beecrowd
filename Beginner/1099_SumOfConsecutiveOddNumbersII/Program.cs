// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int X = int.Parse(inputs[0]);
    int Y = int.Parse(inputs[1]);

    int max = Math.Max(X, Y);
    int min = Math.Min(X, Y);
    int sumOfOddNumbers = 0;

    for (int j = min + 1; j <= max - 1; j++)
    {
        if (j % 2 != 0)
        {
            sumOfOddNumbers += j;
        }
    }

    Console.WriteLine("{0}", sumOfOddNumbers);
}
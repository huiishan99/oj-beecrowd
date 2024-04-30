// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int X = int.Parse(inputs[0]);
    int Y = int.Parse(inputs[1]);
    int sum = 0;

    if (X % 2 == 0)
    {
        X++;
    }

    for (int j = 0; j < Y; j++)
    {
        sum += X;
        X += 2;
    }

    Console.WriteLine(sum);
}
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int X = int.Parse(inputs[0]);
    int Y = int.Parse(inputs[1]);

    if (Y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double divisor = X * 1.0 / Y;
        Console.WriteLine("{0:F1}", divisor);
    }
}
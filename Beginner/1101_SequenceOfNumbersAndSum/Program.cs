// See https://aka.ms/new-console-template for more information

while (true)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int M = int.Parse(inputs[0]);
    int N = int.Parse(inputs[1]);

    if (M <= 0 || N <= 0) break;

    int max = Math.Max(M, N);
    int min = Math.Min(M, N);
    int sum = 0;

    for (int i = min; i <= max; i++)
    {
        Console.Write("{0} ", i);
        sum += i;
    }

    Console.WriteLine("Sum={0}", sum);
}
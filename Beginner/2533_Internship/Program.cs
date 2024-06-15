// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    int M = int.Parse(line);
    int[] N = new int[M + 1];
    int[] C = new int[M + 1];
    int sumNC = 0;
    int sumC100 = 0;

    for (int i = 1; i <= M; i++)
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' });
        N[i] = int.Parse(input[0]);
        C[i] = int.Parse(input[1]);

        sumNC += N[i] * C[i];
        sumC100 += C[i] * 100;
    }

    double result = sumNC * 1.0 / sumC100;
    Console.WriteLine($"{result:F4}");
}
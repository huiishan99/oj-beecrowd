// See https://aka.ms/new-console-template for more information

int T = int.Parse(Console.ReadLine());

for (int i = 1; i <= T; i++)
{
    string method = Console.ReadLine();
    string[] inputValue = Console.ReadLine().Split(new[] { ' ' });
    int R = int.Parse(inputValue[0]);
    int G = int.Parse(inputValue[1]);
    int B = int.Parse(inputValue[2]);

    if (method == "eye")
    {
        double P = (R * 30.0 / 100) + (G * 59.0 / 100) + (B * 11.0 / 100);
        Console.WriteLine("Caso #{0}: {1}", i, (int)P);
    }
    else if (method == "min")
    {
        Console.WriteLine("Caso #{0}: {1}", i, Math.Min(Math.Min(R, G), B));
    }
    else if (method == "max")
    {
        Console.WriteLine("Caso #{0}: {1}", i, Math.Max(Math.Max(R, G), B));
    }
    else
    {
        double mean = (R + G + B) * 1.0 / 3;
        Console.WriteLine("Caso #{0}: {1}", i, (int)mean);
    }
}
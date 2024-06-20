// See https://aka.ms/new-console-template for more information

string input;
while ((input = Console.ReadLine()) != null)
{
    int M = int.Parse(input);
    int[] coinValues = new int[M];

    for (int i = 0; i < M; i++)
    {
        coinValues[i] = int.Parse(Console.ReadLine());
    }

    int chooseByGloria = int.Parse(Console.ReadLine());

    int sum = 0;
    for (int i = M - 1; i >= 0; i -= chooseByGloria)
    {
        sum += coinValues[i];
    }

    if (IsPrime(sum))
    {
        Console.WriteLine("You’re a coastal aircraft, Robbie, a large silver aircraft.");
    }
    else
    {
        Console.WriteLine("Bad boy! I’ll hit you.");
    }
}

static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }

    if (number % 2 == 0 && number != 2)
    {
        return false;
    }

    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}
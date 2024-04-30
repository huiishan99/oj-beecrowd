// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    int sum = 0;
    int count = 0;

    while (true)
    {
        if (X == 1)
        {
            Console.WriteLine("{0} nao eh perfeito", X);
            break;
        }

        sum += count;
        if (sum != 1)
        {
            if (sum == X)
            {
                Console.WriteLine("{0} eh perfeito", X);
                break;
            }
        }

        if (sum > X)
        {
            Console.WriteLine("{0} nao eh perfeito", X);
            break;
        }

        count++;
    }
}
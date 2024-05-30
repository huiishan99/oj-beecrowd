// See https://aka.ms/new-console-template for more information

int number = int.Parse(Console.ReadLine());
string[] mountains = Console.ReadLine().Split(new[] { ' ' });

bool isSamePattern = true;

for (int i = 1; i < number; i++)
{
    int currentMount = int.Parse(mountains[i]);
    int previousMount = int.Parse(mountains[i - 1]);

    if (i == 1)
    {
        if (currentMount == previousMount)
        {
            isSamePattern = false;
            break;
        }
    }
    else
    {
        int secondPreviosMount = int.Parse(mountains[i - 2]);
        if ((currentMount >= previousMount && previousMount >= secondPreviosMount) ||
            (currentMount <= previousMount && previousMount <= secondPreviosMount))
        {
            isSamePattern = false;
            break;
        }
    }
}

if (isSamePattern)
    Console.WriteLine(1);
else
    Console.WriteLine(0);
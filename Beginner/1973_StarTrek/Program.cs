long n = long.Parse(Console.ReadLine());
int[] sheep = new int[n];
bool[] star = new bool[n];
long starCount = 0;
long sheepCount = 0;

string[] inputSheep = Console.ReadLine().Split(new[] { ' ' });

for (long i = 0; i < n; i++)
{
    sheep[i] = int.Parse(inputSheep[i]);
    star[i] = false;
}

long currentPosition = 0;

while (true)
{
    if (currentPosition == 0 && sheep[currentPosition] % 2 == 0)
    {
        star[currentPosition] = true;
        if (sheep[currentPosition] > 0)
            sheep[currentPosition]--;
        break;
    }
    else if (currentPosition == n - 1 && sheep[currentPosition] % 2 == 1)
    {
        star[currentPosition] = true;
        if (sheep[currentPosition] > 0)
            sheep[currentPosition]--;
        break;
    }

    if (sheep[currentPosition] % 2 == 1)
    {
        star[currentPosition] = true;
        sheep[currentPosition]--;
        currentPosition++;
    }
    else
    {
        star[currentPosition] = true;
        if (sheep[currentPosition] > 0)
            sheep[currentPosition]--;
        currentPosition--;
    }
}

for (long i = 0; i < n; i++)
{
    sheepCount += sheep[i];
    if (star[i])
        starCount++;
}

Console.WriteLine($"{starCount} {sheepCount}");
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    long X = long.Parse(Console.ReadLine());
    string binaryString = Convert.ToString(X, 2);

    int maxConsecutiveOnes = FindMaxConsecutiveOnes(binaryString);

    Console.WriteLine(maxConsecutiveOnes);
}

static int FindMaxConsecutiveOnes(string binaryString)
{
    int maxCount = 0;
    int currentCount = 0;

    foreach (char c in binaryString)
    {
        if (c == '1')
        {
            currentCount++;
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
        }
        else
        {
            currentCount = 0;
        }
    }

    return maxCount;
}
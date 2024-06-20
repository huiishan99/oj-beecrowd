// See https://aka.ms/new-console-template for more information

string[] line1 = Console.ReadLine().Split(new[] { ' ' });
string[] line2 = Console.ReadLine().Split(new[] { ' ' });

int[] mealAvailable = new int[3];
int[] mealRequested = new int[3];

int count = 0;

for (int i = 0; i < 3; i++)
{
    mealAvailable[i] = int.Parse(line1[i]);
    mealRequested[i] = int.Parse(line2[i]);

    if (mealRequested[i] > mealAvailable[i])
    {
        count += mealRequested[i] - mealAvailable[i];
    }
}

Console.WriteLine(count);
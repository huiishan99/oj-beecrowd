// See https://aka.ms/new-console-template for more information

int numberOfStars = int.Parse(Console.ReadLine());
string[] inputNumberOfSheep = Console.ReadLine().Split(new[] { ' ' });
int[] numberOfSheep = new int[numberOfStars];

for (int i = 0; i < numberOfStars; i++)
{
    numberOfSheep[i] = int.Parse(inputNumberOfSheep[i]);
}

bool[] attackedStar = new bool[numberOfStars];
int position = 0;
while (position < numberOfStars)
{
    if (position == 0 && attackedStar[position]) break;
    if (numberOfSheep[position] % 2 != 0)
    {
        numberOfSheep[position]--;
        attackedStar[position] = true;
        position++;
    }
    else
    {
        if (!attackedStar[position])
        {
            numberOfSheep[position]--;
            attackedStar[position] = true;
        }

        position--;
    }
}

int allAttackedStar = 0;
int nonStolenSheeps = 0;
for (int i = 0; i < numberOfStars; i++)
{
    nonStolenSheeps += numberOfSheep[i];
    allAttackedStar += attackedStar[i];
}

Console.WriteLine("{0} {1}", allAttackedStar, nonStolenSheeps);
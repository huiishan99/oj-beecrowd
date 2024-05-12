// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    int year = int.Parse(Console.ReadLine());
    int minusYears = 2015 - year;
    if (minusYears < 1)
    {
        minusYears -= 1;
        Console.WriteLine("{0} A.C.", Math.Abs(minusYears));
    }
    else Console.WriteLine("{0} D.C.", minusYears);
}
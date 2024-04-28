// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int oddNumber;
int a = 0;

if (X % 2 != 0)
{
    Console.WriteLine(X);
    a++;
}

for (int i = 1; a < 6; i++)
{
    oddNumber = X + i;
    if (oddNumber % 2 != 0)
    {
        Console.WriteLine("{0}", oddNumber);
        a++;
    }
}
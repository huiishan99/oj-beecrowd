// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int oddNumber;

for (int i = 1; i <= X; i++)
{
    oddNumber = i;
    if (oddNumber % 2 != 0)
    {
        Console.WriteLine("{0}", oddNumber);
    }
}
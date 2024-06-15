// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string villain = Console.ReadLine();

    if (villain == "Batmain")
    {
        Console.WriteLine("N");
    }
    else
    {
        Console.WriteLine("Y");
    }
}
// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();

int count = 0;
foreach (char c in input)
{
    if (c == '1')
    {
        count++;
    }
}

if (count % 2 != 0)
    Console.WriteLine(input + "1");
else
    Console.WriteLine(input + "0");
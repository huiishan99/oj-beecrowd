// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    int paperNumber = int.Parse(input);
    int password = paperNumber - 1;

    Console.WriteLine(password);
}
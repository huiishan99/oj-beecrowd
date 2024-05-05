// See https://aka.ms/new-console-template for more information

string inputs;

while ((inputs = Console.ReadLine()) != null)
{
    int N = int.Parse(inputs);
    if (N > 0)
    {
        Console.WriteLine("vai ter duas!");
    }
    else
    {
        Console.WriteLine("vai ter copa!");
    }
}
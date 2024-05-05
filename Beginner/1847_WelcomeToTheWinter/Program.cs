// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);
int c = int.Parse(inputs[2]);

if (a > b)
{
    if (b > c && b - c >= a - b) Console.WriteLine(":(");
    else Console.WriteLine(":)");
}

if (a < b)
{
    if (b < c && c - b >= b - a) Console.WriteLine(":)");
    else Console.WriteLine(":(");
}

if (a == b)
{
    if (c > b) Console.WriteLine(":)");
    else Console.WriteLine(":(");
}
// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

if (a == b) Console.WriteLine(a);
else
{
    int max = Math.Max(a, b);
    Console.WriteLine(max);
}
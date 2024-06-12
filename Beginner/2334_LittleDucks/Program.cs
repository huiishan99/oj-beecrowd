// See https://aka.ms/new-console-template for more information

using System.Numerics;

BigInteger input;
while ((input = BigInteger.Parse(Console.ReadLine())) != -1)
{
    if (input == 0)
        Console.WriteLine(0);
    else
        Console.WriteLine(input - 1);
}
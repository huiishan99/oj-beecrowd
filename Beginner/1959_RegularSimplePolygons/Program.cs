// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
long numberOfSides = long.Parse(inputs[0]);
long length = long.Parse(inputs[1]);

long perimeter = numberOfSides * length;

Console.WriteLine("{0}", perimeter);
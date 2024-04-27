// See https://aka.ms/new-console-template for more information

string[] inputs1 = Console.ReadLine().Split(new char[] { ' ' });
double x1 = double.Parse(inputs1[0]);
double y1 = double.Parse(inputs1[1]);

string[] inputs2 = Console.ReadLine().Split(new char[] { ' ' });
double x2 = double.Parse(inputs2[0]);
double y2 = double.Parse(inputs2[1]);

double Distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

Console.WriteLine("{0:F4}", Distance);
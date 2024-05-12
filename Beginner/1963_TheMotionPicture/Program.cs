// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
double oldPrice = double.Parse(inputs[0]);
double newPrice = double.Parse(inputs[1]);

double percentage = (newPrice - oldPrice) / oldPrice * 100;
Console.WriteLine("{0:F2}%", percentage);
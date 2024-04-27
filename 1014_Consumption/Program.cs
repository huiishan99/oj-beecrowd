// See https://aka.ms/new-console-template for more information

int distance = int.Parse(Console.ReadLine());
double fuel = double.Parse(Console.ReadLine());

double consumption = distance/fuel;

Console.WriteLine("{0:F3} km/l",consumption);
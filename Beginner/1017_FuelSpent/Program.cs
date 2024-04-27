// See https://aka.ms/new-console-template for more information

int times = int.Parse(Console.ReadLine());
int averageSpeed = int.Parse(Console.ReadLine());

double spent = (times * averageSpeed) / 12.0;

Console.WriteLine("{0:F3}", spent);
// See https://aka.ms/new-console-template for more information

double Pi = 3.14159;
double R = double.Parse(Console.ReadLine());

double VOLUME = (4.0 / 3.0) * Pi * R * R * R;

Console.WriteLine("VOLUME = {0:F3}", VOLUME);
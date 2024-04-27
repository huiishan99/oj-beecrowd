// See https://aka.ms/new-console-template for more information

double A = double.Parse(Console.ReadLine());
double B = double.Parse(Console.ReadLine());
double C = double.Parse(Console.ReadLine());

double weightA = 2;
double weightB = 3; 
double weightC = 5;
double totalWeight = weightA + weightB + weightC;

double MEDIA = ((A * weightA) + (B * weightB) + (C * weightC)) / totalWeight;

Console.WriteLine("MEDIA = {0:F1}", MEDIA);
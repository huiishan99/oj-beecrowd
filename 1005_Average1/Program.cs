// See https://aka.ms/new-console-template for more information

double A = double.Parse(Console.ReadLine());
double B = double.Parse(Console.ReadLine());

double weightA = 3.5;
double weightB = 7.5;
double totalWeight = weightA + weightB;

double MEDIA = ((A * weightA) + (B* weightB)) / totalWeight;

Console.WriteLine("MEDIA = {0:F5}", MEDIA);
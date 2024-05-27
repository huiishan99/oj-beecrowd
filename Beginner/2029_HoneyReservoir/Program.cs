// See https://aka.ms/new-console-template for more information

double pi = 3.14;
string stringVolume, stringDiameter;

while ((stringVolume = Console.ReadLine()) != null && (stringDiameter = Console.ReadLine()) != null)
{
    if (double.TryParse(stringVolume, out double volume) && double.TryParse(stringDiameter, out double diameter))
    {
        double radius = diameter / 2;
        double area = pi * radius * radius;
        double height = volume / area;

        Console.WriteLine("ALTURA = {0:F2}", height);
        Console.WriteLine("AREA = {0:F2}", area);
    }
}
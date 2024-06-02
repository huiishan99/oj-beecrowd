// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    string[] values = input.Split(new[] { ' ' });
    int fiddlesticksX = int.Parse(values[0]);
    int fiddlesticksY = int.Parse(values[1]);
    int invaderX = int.Parse(values[2]);
    int invaderY = int.Parse(values[3]);
    int speed = int.Parse(values[4]);
    int ultimateRadius = int.Parse(values[5]);
    int flightRadius = int.Parse(values[6]);

    double distance = Math.Sqrt(Math.Pow(fiddlesticksX - invaderX, 2) + Math.Pow(fiddlesticksY - invaderY, 2));
    double distanceAfterChannel = distance + 1.5 * speed;

    if (ultimateRadius + flightRadius >= distanceAfterChannel)
        Console.WriteLine("Y");
    else
        Console.WriteLine("N");
}
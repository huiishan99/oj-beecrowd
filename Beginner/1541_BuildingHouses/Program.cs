// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != "0")
{
    string[] ABC = input.Split(new[] { ' ' });

    int A = int.Parse(ABC[0]);
    int B = int.Parse(ABC[1]);
    int C = int.Parse(ABC[2]);

    int houseArea = A * B;
    double maxLandArea = houseArea * 100 / C;
    double landSide = Math.Sqrt(maxLandArea);
    int truncatedLandSide = (int)Math.Truncate(landSide);

    Console.WriteLine(truncatedLandSide);
}
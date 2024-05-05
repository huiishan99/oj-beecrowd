// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    int teseCases = int.Parse(line);
    string[] slugSpeeds = Console.ReadLine().Split(new[] { ' ' });
    for (int i = 0; i < teseCases; i++)
    {
        int eachSlugSpeed = int.Parse(slugSpeeds[i]);
    }

    int maxSlugSpeed = int.Parse(slugSpeeds[0]);
    foreach (string speed in slugSpeeds)
    {
        if (int.Parse(speed) > maxSlugSpeed)
        {
            maxSlugSpeed = int.Parse(speed);
        }
    }

    if (maxSlugSpeed >= 20)
    {
        Console.WriteLine(3);
    }
    else if (maxSlugSpeed >= 10)
    {
        Console.WriteLine(2);
    }
    else
    {
        Console.WriteLine(1);
    }
}
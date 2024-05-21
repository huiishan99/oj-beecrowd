// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] inputTime = line.Split(new[] { ':' });
    int hour = int.Parse(inputTime[0]);
    int minute = int.Parse(inputTime[1]);

    if (hour >= 7)
    {
        if (hour >= 8)
        {
            if (hour == 9)
            {
                Console.WriteLine("Atraso maximo: {0}", minute + 120);
            }
            else
            {
                Console.WriteLine("Atraso maximo: {0}", minute + 60);
            }
        }
        else
        {
            Console.WriteLine("Atraso maximo: {0}", minute);
        }
    }
    else
    {
        Console.WriteLine("Atraso maximo: 0");
    }
}
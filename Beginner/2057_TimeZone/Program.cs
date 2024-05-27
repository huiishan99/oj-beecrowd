// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int dapatureTime = int.Parse(inputs[0]);
int travelTimes = int.Parse(inputs[1]);
int destinationTimeZone = int.Parse(inputs[2]);

int localTime = dapatureTime + travelTimes + destinationTimeZone;

if (localTime >= 24)
{
    if (localTime == 24)
    {
        localTime = 0;
    }
    else
    {
        localTime -= 24;
    }
}
else if (localTime < 0)
{
    localTime += 24;
}

Console.WriteLine(localTime);
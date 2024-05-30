// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int hour = int.Parse(inputs[0]);
    int minute = int.Parse(inputs[1]);
    int doorLock = int.Parse(inputs[2]);

    if (doorLock == 1)
        Console.WriteLine("{0:D2}:{1:D2} - A porta abriu!", hour, minute);
    else
        Console.WriteLine("{0:D2}:{1:D2} - A porta fechou!", hour, minute);
}
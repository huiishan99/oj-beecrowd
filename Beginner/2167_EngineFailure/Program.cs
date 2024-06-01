// See https://aka.ms/new-console-template for more information

int number = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(new[] { ' ' });

int[] engineSpeed = new int[number];
engineSpeed[0] = int.Parse(input[0]);

bool speedFall = false;

for (int i = 1; i < number; i++)
{
    engineSpeed[i] = int.Parse(input[i]);
    if (engineSpeed[i] < engineSpeed[i - 1])
    {
        Console.WriteLine(i + 1);
        speedFall = true;
        break;
    }
}

if (speedFall == false) Console.WriteLine(0);
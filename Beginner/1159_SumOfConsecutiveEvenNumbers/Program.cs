// See https://aka.ms/new-console-template for more information

while (true)
{
    int input = int.Parse(Console.ReadLine());
    if (input == 0) break;

    int X = input;
    int sum = 0;

    if (X % 2 != 0) X++;

    for (int i = 0; i < 5; i++)
    {
        sum += X;
        X += 2;
    }

    Console.WriteLine(sum);
}
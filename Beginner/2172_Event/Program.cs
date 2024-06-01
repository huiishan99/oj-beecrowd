// See https://aka.ms/new-console-template for more information

while (true)
{
    string[] input = Console.ReadLine().Split(new[] { ' ' });
    int multiple = int.Parse(input[0]);
    int expValue = int.Parse(input[1]);

    if (multiple == 0 && expValue == 0) break;
    Console.WriteLine(multiple * expValue);
}
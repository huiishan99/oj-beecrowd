// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string input = Console.ReadLine();
    double spendTime = input.Length * 0.01;
    Console.WriteLine($"{spendTime:F2}");
}
// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());

int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
string[] numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

for (int i = 0; i < numbers.Length; i++)
{
    while (input >= numbers[i])
    {
        input = input - numbers[i];
        Console.Write(numerals[i]);
    }
}

Console.WriteLine();
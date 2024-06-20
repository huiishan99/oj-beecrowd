// See https://aka.ms/new-console-template for more information

int A1 = int.Parse(Console.ReadLine());
int A2 = int.Parse(Console.ReadLine());
int A3 = int.Parse(Console.ReadLine());

int coffeeA1 = A3 * 4 + A2 * 2;
int coffeeA2 = A1 * 2 + A3 * 2;
int coffeeA3 = A1 * 4 + A2 * 2;

int result = Math.Min(coffeeA1, Math.Min(coffeeA2, coffeeA3));

Console.WriteLine(result);
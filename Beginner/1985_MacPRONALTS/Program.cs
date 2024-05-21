// See https://aka.ms/new-console-template for more information
// using System.Collections.Generic;

Dictionary<int, double> menu = new Dictionary<int, double>
{
    [1001] = 1.5,
    [1002] = 2.5,
    [1003] = 3.5,
    [1004] = 4.5,
    [1005] = 5.5
};

int productNumbers = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 0; i < productNumbers; i++)
{
    string[] input = Console.ReadLine().Split(new[] { ' ' });
    int keyNumber = int.Parse(input[0]);
    int quantity = int.Parse(input[1]);

    sum += menu[keyNumber] * quantity;
}

Console.WriteLine("{0:F2}", sum);
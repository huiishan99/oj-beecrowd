// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new char[] { ' ' });
int code = int.Parse(inputs[0]);
int quantity = int.Parse(inputs[1]);

double[] price = { 0, 4.00, 4.50, 5.00, 2.00, 1.50 };

double total = price[code] * quantity;

Console.WriteLine("Total: R$ {0:F2}", total);
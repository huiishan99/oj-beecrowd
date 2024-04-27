// See https://aka.ms/new-console-template for more information

string[] product1 = Console.ReadLine().Split(new char[] { ' ' });
int code1 = int.Parse(product1[0]);
int units1 = int.Parse(product1[1]);
double price1 = double.Parse(product1[2]);

string[] product2 = Console.ReadLine().Split(new char[] { ' ' });
int code2 = int.Parse(product2[0]);
int units2 = int.Parse(product2[1]);
double price2 = double.Parse(product2[2]);

double total = (units1 * price1) + (units2 * price2);

Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
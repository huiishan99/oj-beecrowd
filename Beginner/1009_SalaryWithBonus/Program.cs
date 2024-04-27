// See https://aka.ms/new-console-template for more information

string NAME = Console.ReadLine();
double SALARY = double.Parse(Console.ReadLine());
double productsSold = double.Parse(Console.ReadLine());

double totalSalary = SALARY + ((productsSold * 15) / 100);

Console.WriteLine("TOTAL = R$ {0:F2}", totalSalary);
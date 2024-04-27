// See https://aka.ms/new-console-template for more information

int NUMBER = int.Parse(Console.ReadLine());
int workedHours = int.Parse(Console.ReadLine());
double receivesPerWorkedHour = double.Parse(Console.ReadLine());

double SALARY = workedHours * receivesPerWorkedHour;

Console.WriteLine("NUMBER = {0}", NUMBER);
Console.WriteLine("SALARY = U$ {0:F2}", SALARY);
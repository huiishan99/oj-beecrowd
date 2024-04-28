// See https://aka.ms/new-console-template for more information

double salary = double.Parse(Console.ReadLine());

double percentage = 0;

if (salary <= 400)
{
    percentage = 0.15;
}
else if (salary <= 800)
{
    percentage = 0.12;
}
else if (salary <= 1200)
{
    percentage = 0.10;
}
else if (salary <= 2000)
{
    percentage = 0.07;
}
else
{
    percentage = 0.04;
}

double monerEarned = salary * percentage;
double newSalary = salary + monerEarned;

Console.WriteLine("Novo salario: {0:F2}", newSalary);
Console.WriteLine("Reajuste ganho: {0:F2}", monerEarned);
Console.WriteLine("Em percentual: {0} %", percentage * 100);
// See https://aka.ms/new-console-template for more information

int inputs = int.Parse(Console.ReadLine());

int years = inputs / 365;
int remainingDays = inputs % 365;
int months = remainingDays / 30;
int days = remainingDays % 30;

Console.WriteLine("{0} ano(s)", years);
Console.WriteLine("{0} mes(es)", months);
Console.WriteLine("{0} dia(s)", days);
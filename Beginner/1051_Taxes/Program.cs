// See https://aka.ms/new-console-template for more information

double salary = double.Parse(Console.ReadLine());
double tax;

if (salary <= 2000)
{
    Console.WriteLine("Isento");
}
else
{
    if (salary <= 3000)
    {
        tax = (salary - 2000) * 0.08;
    }
    else if (salary <= 4500)
    {
        tax = ((salary - 3000) * 0.18) + (1000 * 0.08);
    }
    else
    {
        tax = ((salary - 4500) * 0.28) + (1500 * 0.18) + (1000 * 0.08);
    }

    Console.WriteLine("R$ {0:F2}", tax);
}
// See https://aka.ms/new-console-template for more information

int alcohol = 0;
int gasoline = 0;
int diesel = 0;

while (true)
{
    int inputs = int.Parse(Console.ReadLine());

    if (inputs == 1) alcohol++;
    if (inputs == 2) gasoline++;
    if (inputs == 3) diesel++;
    if (inputs == 4)
    {
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: {0}", alcohol);
        Console.WriteLine("Gasolina: {0}", gasoline);
        Console.WriteLine("Diesel: {0}", diesel);
        break;
    }
}
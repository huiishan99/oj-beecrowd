// See https://aka.ms/new-console-template for more information

string input;
while ((input = Console.ReadLine()) != null)
{
    int degree = int.Parse(input);

    if (degree >= 90 && degree < 360)
    {
        if (degree >= 90 && degree < 180)
        {
            Console.WriteLine("Boa Tarde!!");
        }
        else if (degree >= 270 && degree < 360)
        {
            Console.WriteLine("De Madrugada!!");
        }
        else
        {
            Console.WriteLine("Boa Noite!!");
        }
    }
    else
    {
        Console.WriteLine("Bom Dia!!");
    }
}
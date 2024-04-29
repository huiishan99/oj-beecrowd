// See https://aka.ms/new-console-template for more information

while (true)
{
    int input = int.Parse(Console.ReadLine());

    if (input == 2002)
    {
        Console.WriteLine("Acesso Permitido");
        break;
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }
}
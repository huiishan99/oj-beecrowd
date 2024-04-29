// See https://aka.ms/new-console-template for more information

int startJ = 7;

for (int I = 1; I <= 9; I += 2)
{
    for (int J = startJ; J >= (startJ - 2); J--)
    {
        Console.WriteLine("I={0} J={1}", I, J);
    }

    startJ += 2;
}
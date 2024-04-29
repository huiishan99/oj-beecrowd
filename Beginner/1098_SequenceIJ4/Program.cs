// See https://aka.ms/new-console-template for more information

for (double I = 0; I <= 2; I += 0.2)
{
    for (int j = 1; j <= 3; j++)
    {
        double J = j + I;
        Console.WriteLine("I={0} J={1}", I, J);
    }
}
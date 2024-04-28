// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
double X = double.Parse(inputs[0]);
double Y = double.Parse(inputs[1]);

if (X == 0 && Y == 0)
{
    Console.WriteLine("Origem");
}
else if (X == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (Y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (X > 0)
{
    if (Y > 0)
    {
        Console.WriteLine("Q1");
    }
    else
    {
        Console.WriteLine("Q4");
    }
}
else
{
    if (Y > 0)
    {
        Console.WriteLine("Q2");
    }
    else
    {
        Console.WriteLine("Q3");
    }
}
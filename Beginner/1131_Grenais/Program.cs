// See https://aka.ms/new-console-template for more information

int grenais = 0;
int interVictory = 0;
int gremioVictory = 0;
int draw = 0;
int choice = 0;

while (true)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int interScore = int.Parse(inputs[0]);
    int gremioScore = int.Parse(inputs[1]);

    if (interScore > gremioScore)
    {
        interVictory++;
    }
    else if (gremioScore > interScore)
    {
        gremioVictory++;
    }
    else
    {
        draw++;
    }

    grenais++;
    do
    {
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        choice = int.Parse(Console.ReadLine());
    } while (choice != 1 && choice != 2);

    if (choice == 2)
    {
        break;
    }
}

Console.WriteLine("{0} grenais", grenais);
Console.WriteLine("Inter:{0}", interVictory);
Console.WriteLine("Gremio:{0}", gremioVictory);
Console.WriteLine("Empates:{0}", draw);

if (interVictory > gremioVictory)
{
    Console.WriteLine("Inter venceu mais");
}
else if (gremioVictory > interVictory)
{
    Console.WriteLine("Gremio venceu mais");
}
else
{
    Console.WriteLine("Não houve vencedor");
}
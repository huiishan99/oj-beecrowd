// See https://aka.ms/new-console-template for more information

int testCases = int.Parse(Console.ReadLine());

for (int i = 0; i < testCases; i++)
{
    string player1 = Console.ReadLine();
    string player2 = Console.ReadLine();

    if (player1 == player2)
    {
        if (player1 == "papel")
        {
            Console.WriteLine("Ambos venceram");
        }

        if (player1 == "pedra")
        {
            Console.WriteLine("Sem ganhador");
        }

        if (player1 == "ataque")
        {
            Console.WriteLine("Aniquilacao mutua");
        }
    }
    else
    {
        if (player1 == "ataque")
        {
            Console.WriteLine("Jogador 1 venceu");
        }

        if (player1 == "pedra")
        {
            if (player2 == "papel")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else
            {
                Console.WriteLine("Jogador 2 venceu");
            }
        }

        if (player1 == "papel")
        {
            Console.WriteLine("Jogador 2 venceu");
        }
    }
}
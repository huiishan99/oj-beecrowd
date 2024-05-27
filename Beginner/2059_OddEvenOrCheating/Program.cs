// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int p = int.Parse(inputs[0]); // 1 == Even; 0 == Odd;
int j1 = int.Parse(inputs[1]); // player1
int j2 = int.Parse(inputs[2]); // player2
int r = int.Parse(inputs[3]); // cheated
int a = int.Parse(inputs[4]); // accused

int player1Win = 1; // 1 == Win; 0 == Lose;

if (r == 1)
{
    if (a == 1)
    {
        player1Win = 0;
    }
}
else if (p == 1)
{
    if ((j1 + j2) % 2 != 0)
    {
        player1Win = 0;
    }
}
else
{
    if ((j1 + j2) % 2 == 0)
    {
        player1Win = 0;
    }
}

if (player1Win == 1)
{
    Console.WriteLine("Jogador 1 ganha!");
}
else
{
    Console.WriteLine("Jogador 2 ganha!");
}
// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int start = int.Parse(inputs[0]);
int end = int.Parse(inputs[1]);

int duration;
if (end >= start)
{
    duration = end - start;
    if (duration == 0)
    {
        Console.WriteLine("O JOGO DUROU 24 HORA(S)");
    }
    else
    {
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", duration);
    }
}
else
{
    duration = 24 - start + end;
    Console.WriteLine("O JOGO DUROU {0} HORA(S)", duration);
}
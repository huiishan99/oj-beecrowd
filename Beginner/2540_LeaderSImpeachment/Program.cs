// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    int number = int.Parse(line);
    string[] voteInput = Console.ReadLine().Split(new[] { ' ' });
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (voteInput[i] == "1")
        {
            count++;
        }
    }

    if (count >= number * 2.0 / 3)
    {
        Console.WriteLine("impeachment");
    }
    else
    {
        Console.WriteLine("acusacao arquivada");
    }
}
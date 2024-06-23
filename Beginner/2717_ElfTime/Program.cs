// See https://aka.ms/new-console-template for more information

string input;
while ((input = Console.ReadLine()) != null)
{
    int N = int.Parse(input);
    string[] secondLine = Console.ReadLine().Split(new[] { ' ' });
    int A = int.Parse(secondLine[0]);
    int B = int.Parse(secondLine[1]);

    if (A + B > N)
    {
        Console.WriteLine("Deixa para amanha!");
    }
    else
    {
        Console.WriteLine("Farei hoje!");
    }
}
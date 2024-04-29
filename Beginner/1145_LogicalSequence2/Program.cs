// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int X = int.Parse(inputs[0]);
int Y = int.Parse(inputs[1]);
int nextLine = 1;

for (int i = 0; i < Y; i += X)
{
    for (int j = 1; j <= X; j++)
    {
        if (j == X)
        {
            Console.WriteLine("{0}", nextLine);
        }
        else
        {
            Console.Write("{0} ", nextLine);
        }

        nextLine++;
    }
}
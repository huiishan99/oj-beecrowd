// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int tabNumber = int.Parse(inputs[0]);
int actionNumber = int.Parse(inputs[1]);

for (int i = 0; i < actionNumber; i++)
{
    string action = Console.ReadLine();

    if (action == "fechou") tabNumber++;
    if (action == "clicou") tabNumber--;
}

Console.WriteLine(tabNumber);
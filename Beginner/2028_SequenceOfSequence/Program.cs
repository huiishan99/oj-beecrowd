// See https://aka.ms/new-console-template for more information

using System.Text;

int caseNumber = 1;
string input;

while ((input = Console.ReadLine()) != null)
{
    int N = int.Parse(input);
    int sum = 1 + ((N * (N + 1)) / 2);

    if (N == 0) Console.WriteLine("Caso {0}: {1} numero", caseNumber, sum);
    else Console.WriteLine("Caso {0}: {1} numeros", caseNumber, sum);

    StringBuilder sequence = new StringBuilder();
    sequence.Append("0 ");
    for (int i = 0; i <= N; i++)
    {
        for (int j = 0; j < i; j++)
        {
            sequence.Append(i).Append(" ");
        }
    }

    Console.WriteLine(sequence.ToString().Trim());
    Console.WriteLine();

    caseNumber++;
}
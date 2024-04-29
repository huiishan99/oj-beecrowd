// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
int coelho = 0;
int rato = 0;
int sapo = 0;
int totalAmount = 0;

for (int i = 0; i < N; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int amount = int.Parse(inputs[0]);
    char type = char.Parse(inputs[1]);

    if (type == 'C')
    {
        coelho = coelho + amount;
    }

    if (type == 'R')
    {
        rato = rato + amount;
    }

    if (type == 'S')
    {
        sapo = sapo + amount;
    }

    totalAmount = totalAmount + amount;
}

double coelhoPercentage = (coelho * 1.0 / totalAmount) * 100.0;
double ratoPercentage = (rato * 1.0 / totalAmount) * 100.0;
double sapoPercentage = (sapo * 1.0 / totalAmount) * 100.0;

Console.WriteLine("Total: {0} cobaias", totalAmount);
Console.WriteLine("Total de coelhos: {0}", coelho);
Console.WriteLine("Total de ratos: {0}", rato);
Console.WriteLine("Total de sapos: {0}", sapo);
Console.WriteLine("Percentual de coelhos: {0:F2} %", coelhoPercentage);
Console.WriteLine("Percentual de ratos: {0:F2} %", ratoPercentage);
Console.WriteLine("Percentual de sapos: {0:F2} %", sapoPercentage);
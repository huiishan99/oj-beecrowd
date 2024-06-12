// See https://aka.ms/new-console-template for more information

int numbers = int.Parse(Console.ReadLine());
int totalService = 0;
int totalBlocks = 0;
int totalAttack = 0;
int SuccessService = 0;
int SuccessBlocks = 0;
int SuccessAttack = 0;

for (int i = 0; i < numbers; i++)
{
    string name = Console.ReadLine();
    string[] firstRow = Console.ReadLine().Split(new[] { ' ' });
    totalService += int.Parse(firstRow[0]);
    totalBlocks += int.Parse(firstRow[1]);
    totalAttack += int.Parse(firstRow[2]);
    string[] secondRow = Console.ReadLine().Split(new[] { ' ' });
    SuccessService += int.Parse(secondRow[0]);
    SuccessBlocks += int.Parse(secondRow[1]);
    SuccessAttack += int.Parse(secondRow[2]);
}

double percentageService = SuccessService * 1.0 / totalService * 100;
double percentageBlocks = SuccessBlocks * 1.0 / totalBlocks * 100;
double percentageAttack = SuccessAttack * 1.0 / totalAttack * 100;

Console.WriteLine("Pontos de Saque: {0:F2} %.", percentageService);
Console.WriteLine("Pontos de Bloqueio: {0:F2} %.", percentageBlocks);
Console.WriteLine("Pontos de Ataque: {0:F2} %.", percentageAttack);
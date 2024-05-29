// See https://aka.ms/new-console-template for more information

int length = int.Parse(Console.ReadLine());
int[] list = new int[length];

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int factorTwo = 0, factorThree = 0, factorFour = 0, factorFive = 0;

for (int i = 0; i < length; i++)
{
    list[i] = int.Parse(inputs[i]);

    if (list[i] % 2 == 0) factorTwo++;
    if (list[i] % 3 == 0) factorThree++;
    if (list[i] % 4 == 0) factorFour++;
    if (list[i] % 5 == 0) factorFive++;
}

Console.WriteLine("{0} Multiplo(s) de 2", factorTwo);
Console.WriteLine("{0} Multiplo(s) de 3", factorThree);
Console.WriteLine("{0} Multiplo(s) de 4", factorFour);
Console.WriteLine("{0} Multiplo(s) de 5", factorFive);
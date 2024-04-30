// See https://aka.ms/new-console-template for more information

int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int populationA = int.Parse(inputs[0]);
    int populationB = int.Parse(inputs[1]);
    double growingA = double.Parse(inputs[2]);
    double growingB = double.Parse(inputs[3]);

    int years = 0;

    while (populationA <= populationB)
    {
        populationA = populationA + (int)(populationA * growingA / 100);
        populationB = populationB + (int)(populationB * growingB / 100);
        years++;
        if (years > 100)
        {
            Console.WriteLine("Mais de 1 seculo.");
            break;
        }
    }

    if (years <= 100)
    {
        Console.WriteLine("{0} anos.", years);
    }
}
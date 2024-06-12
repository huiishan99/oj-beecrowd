// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, int> foodVitamin = new Dictionary<string, int>
{
    ["suco de laranja"] = 120,
    ["morango fresco"] = 85,
    ["mamao"] = 85,
    ["goiaba vermelha"] = 70,
    ["manga"] = 56,
    ["laranja"] = 50,
    ["brocolis"] = 34
};

int numbers;
while ((numbers = int.Parse(Console.ReadLine())) != 0)
{
    int totalVitamin = 0;
    for (int i = 0; i < numbers; i++)
    {
        string[] inputs = Console.ReadLine().Split(new[] { ' ' }, 2);
        int foodNumber = int.Parse(inputs[0]);
        string foodName = inputs[1];

        totalVitamin += foodNumber * foodVitamin[foodName];
    }

    if (totalVitamin > 130)
    {
        Console.WriteLine("Menos {0} mg", totalVitamin - 130);
    }
    else if (totalVitamin < 110)
    {
        Console.WriteLine("Mais {0} mg", 110 - totalVitamin);
    }
    else
    {
        Console.WriteLine("{0} mg", totalVitamin);
    }
}
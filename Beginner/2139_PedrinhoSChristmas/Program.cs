// See https://aka.ms/new-console-template for more information

int[] lunarDay = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

string input;

while ((input = Console.ReadLine()) != null)
{
    string[] checkChristmas = input.Split(new[] { ' ' });
    int month = int.Parse(checkChristmas[0]);
    int day = int.Parse(checkChristmas[1]);

    if (month == 12 && day >= 24)
    {
        if (day == 24) Console.WriteLine("E vespera de natal!");
        if (day == 25) Console.WriteLine("E natal!");
        if (day > 25) Console.WriteLine("Ja passou!");
    }
    else
    {
        int date = 0;
        for (int i = 1; i < month; i++)
        {
            date += lunarDay[i];
        }

        date += day;
        Console.WriteLine("Faltam {0} dias para o natal!", 360 - date);
    }
}
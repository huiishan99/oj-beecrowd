// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string plate = Console.ReadLine();
    Console.WriteLine(GetRestrictionDay(plate));
}

static string GetRestrictionDay(string plate)
{
    if (!Regex.IsMatch(plate, @"^[A-Z]{3}-\d{4}$"))
    {
        return "FAILURE";
    }

    char lastDigit = plate[plate.Length - 1];

    switch (lastDigit)
    {
        case '1':
        case '2':
            return "MONDAY";
        case '3':
        case '4':
            return "TUESDAY";
        case '5':
        case '6':
            return "WEDNESDAY";
        case '7':
        case '8':
            return "THURSDAY";
        case '9':
        case '0':
            return "FRIDAY";
        default:
            return "FAILURE";
    }
}
// See https://aka.ms/new-console-template for more information

string input;
while ((input = Console.ReadLine()) != null)
{
    double degree = double.Parse(input);
    double resultInMinute;
    double resultInHour = 0;

    if (degree >= 90 && degree < 360)
    {
        if (degree >= 90 && degree < 180)
        {
            Console.WriteLine("Boa Tarde!!");
            resultInMinute = (degree + 90) * 4;
            if (resultInMinute >= 60)
            {
                resultInHour = resultInMinute / 60;
                resultInMinute %= 60;
            }

            Console.WriteLine("{0:D2}:{1:D2}:00", (int)resultInHour, (int)resultInMinute);
        }
        else if (degree >= 270 && degree < 360)
        {
            Console.WriteLine("De Madrugada!!");

            resultInMinute = (degree - 270) * 4;
            if (resultInMinute >= 60)
            {
                resultInHour = resultInMinute / 60;
                resultInMinute %= 60;
            }

            Console.WriteLine("{0:D2}:{1:D2}:00", (int)resultInHour, (int)resultInMinute);
        }
        else
        {
            Console.WriteLine("Boa Noite!!");
            resultInMinute = (degree + 90) * 4;
            if (resultInMinute >= 60)
            {
                resultInHour = resultInMinute / 60;
                resultInMinute %= 60;
            }

            Console.WriteLine("{0:D2}:{1:D2}:00", (int)resultInHour, (int)resultInMinute);
        }
    }
    else
    {
        Console.WriteLine("Bom Dia!!");
        resultInMinute = (degree + 90) * 4;
        if (resultInMinute >= 60)
        {
            resultInHour = resultInMinute / 60;
            resultInMinute %= 60;
        }

        Console.WriteLine("{0:D2}:{1:D2}:00", (int)resultInHour, (int)resultInMinute);
    }
}
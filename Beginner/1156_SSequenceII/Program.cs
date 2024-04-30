// See https://aka.ms/new-console-template for more information

double S = 0;
double numerator = 1;
double denominator = 1;

while (true)
{
    S = S + (numerator * 1.0 / denominator);
    numerator = numerator + 2;
    denominator = denominator * 2;
    if (numerator >= 39)
    {
        S = S + (numerator * 1.0 / denominator);
        break;
    }
}

Console.WriteLine("{0:F2}", S);
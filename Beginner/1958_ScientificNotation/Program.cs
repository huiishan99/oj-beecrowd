// See https://aka.ms/new-console-template for more information

string number = Console.ReadLine();

if (number == "-0") Console.WriteLine("-0.0000E+00");
else
{
    double inpus = double.Parse(number);
    Console.WriteLine(inpus.ToString("+0.0000E+00;-0.0000E+00"));
}
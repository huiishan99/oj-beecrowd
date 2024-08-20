// See https://aka.ms/new-console-template for more information

int[] value = new int[16];
for (int i = 0; i < 16; i++)
{
    value[i] = i;
}

Console.WriteLine(new string('-', 39));

Console.WriteLine("|  decimal  |  octal  |  Hexadecimal  |");

Console.WriteLine(new string('-', 39));

for (int i = 0; i < 16; i++)
{
    Console.WriteLine(
        $"|{value[i],7}    |{Convert.ToString(value[i], 8),5}    |{Convert.ToString(value[i], 16).ToUpper(),8}       |");
}

Console.WriteLine(new string('-', 39));
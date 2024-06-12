// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());

if (input == 0)
    Console.WriteLine("E");
else if (input >= 1 && input <= 35)
    Console.WriteLine("D");
else if (input >= 36 && input <= 60)
    Console.WriteLine("C");
else if (input >= 61 && input <= 85)
    Console.WriteLine("B");
else
    Console.WriteLine("A");
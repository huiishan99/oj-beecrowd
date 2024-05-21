// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();

char[] charArray = input.ToCharArray();
Array.Reverse(charArray);

string reverseNumber = new string(charArray);

Console.WriteLine(reverseNumber);
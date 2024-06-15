// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    char[] charArray = input.ToCharArray();
    int charNum = int.Parse(Console.ReadLine());
    string[] numInput = Console.ReadLine().Split(new[] { ' ' });
    for (int i = 0; i < charNum; i++)
    {
        int selectNum = int.Parse(numInput[i]);

        Console.Write(charArray[selectNum - 1]);
    }

    Console.WriteLine();
}
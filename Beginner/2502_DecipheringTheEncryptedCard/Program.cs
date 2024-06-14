// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

string line;
while ((line = Console.ReadLine()) != null)
{
    if (string.IsNullOrWhiteSpace(line))
        continue;

    string[] parts = line.Split(' ');
    int cipSize = int.Parse(parts[0]);
    int lineNum = int.Parse(parts[1]);

    string line1 = Console.ReadLine();
    string line2 = Console.ReadLine();

    Dictionary<char, char> cipher = new Dictionary<char, char>();

    for (int i = 0; i < cipSize; i++)
    {
        char char1 = line1[i];
        char char2 = line2[i];

        cipher[char.ToUpper(char1)] = char.ToUpper(char2);
        cipher[char.ToUpper(char2)] = char.ToUpper(char1);

        cipher[char.ToLower(char1)] = char.ToLower(char2);
        cipher[char.ToLower(char2)] = char.ToLower(char1);
    }

    for (int i = 0; i < lineNum; i++)
    {
        string encryptedLine = Console.ReadLine();
        string decryptedLine = Decrypt(encryptedLine, cipher);
        Console.WriteLine(decryptedLine);
    }

    Console.WriteLine();
}


static string Decrypt(string text, Dictionary<char, char> cipher)
{
    char[] decrypted = new char[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        char currentChar = text[i];
        if (cipher.ContainsKey(currentChar))
        {
            decrypted[i] = cipher[currentChar];
        }
        else
        {
            decrypted[i] = currentChar;
        }
    }

    return new string(decrypted);
}
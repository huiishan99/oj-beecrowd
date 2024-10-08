// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, char> secretCodeDictionary = new Dictionary<string, char>
{
    ["."] = 'a',
    [".."] = 'b',
    ["..."] = 'c',
    [". ."] = 'd',
    [".. .."] = 'e',
    ["... ..."] = 'f',
    [". . ."] = 'g',
    [".. .. .."] = 'h',
    ["... ... ..."] = 'i',
    [". . . ."] = 'j',
    [".. .. .. .."] = 'k',
    ["... ... ... ..."] = 'l',
    [". . . . ."] = 'm',
    [".. .. .. .. .."] = 'n',
    ["... ... ... ... ..."] = 'o',
    [". . . . . ."] = 'p',
    [".. .. .. .. .. .."] = 'q',
    ["... ... ... ... ... ..."] = 'r',
    [". . . . . . ."] = 's',
    [".. .. .. .. .. .. .."] = 't',
    ["... ... ... ... ... ... ..."] = 'u',
    [". . . . . . . ."] = 'v',
    [".. .. .. .. .. .. .. .."] = 'w',
    ["... ... ... ... ... ... ... ..."] = 'x',
    [". . . . . . . . ."] = 'y',
    [".. .. .. .. .. .. .. .. .."] = 'z'
};

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string inputDot = Console.ReadLine();
    Console.WriteLine(secretCodeDictionary[inputDot]);
}
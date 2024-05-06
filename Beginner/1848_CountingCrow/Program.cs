// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, int> threeEyes = new Dictionary<string, int>()
{
    ["--*"] = 1,
    ["-*-"] = 2,
    ["-**"] = 3,
    ["*--"] = 4,
    ["*-*"] = 5,
    ["**-"] = 6,
    ["***"] = 7
};

for (int i = 0; i < 3; i++)
{
    string input;
    int sum = 0;
    while ((input = Console.ReadLine()) != "caw caw")
    {
        sum += threeEyes[input];
    }

    Console.WriteLine(sum);
}
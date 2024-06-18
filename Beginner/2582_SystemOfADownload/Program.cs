// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<int,string> songList = new Dictionary<int, string>
{
    [0] = "PROXYCITY",
    [1] = "P.Y.N.G.",
    [2] = "DNSUEY!",
    [3] = "SERVERS",
    [4] = "HOST!",
    [5] = "CRIPTONIZE",
    [6] = "OFFLINE DAY",
    [7] = "SALT",
    [8] = "ANSWER!",
    [9] = "RAR?",
    [10] = "WIFI ANTENNAS"
};

int c = int.Parse(Console.ReadLine());

for (int i = 0; i < c; i++)
{
    string[] input = Console.ReadLine().Split(new[] { ' ' });
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    string song = songList[x + y];
    Console.WriteLine(song);
}
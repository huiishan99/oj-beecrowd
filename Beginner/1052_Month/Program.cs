// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<int, string> monthDictionary = new Dictionary<int, string>()
{
    [1] = "January",
    [2] = "February",
    [3] = "March",
    [4] = "April",
    [5] = "May",
    [6] = "June",
    [7] = "July",
    [8] = "August",
    [9] = "September",
    [10] = "October",
    [11] = "November",
    [12] = "December"
};

int input = int.Parse(Console.ReadLine());

monthDictionary.TryGetValue(input, out string month);

Console.WriteLine("{0}", month);
// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

var tree = new Dictionary<string, object>
{
    ["vertebrado"] = new Dictionary<string, object>
    {
        ["ave"] = new Dictionary<string, string>
        {
            ["carnivoro"] = "aguia",
            ["onivoro"] = "pomba"
        },
        ["mamifero"] = new Dictionary<string, string>
        {
            ["onivoro"] = "homem",
            ["herbivoro"] = "vaca"
        }
    },
    ["invertebrado"] = new Dictionary<string, object>
    {
        ["inseto"] = new Dictionary<string, string>
        {
            ["hematofago"] = "pulga",
            ["herbivoro"] = "lagarta"
        },
        ["anelideo"] = new Dictionary<string, string>
        {
            ["hematofago"] = "sanguessuga",
            ["onivoro"] = "minhoca"
        }
    }
};

string firstWord = Console.ReadLine();
string secondWord = Console.ReadLine();
string thirdWord = Console.ReadLine();

var secondLevel = (Dictionary<string, object>)tree[firstWord];
var thirdLevel = (Dictionary<string, string>)secondLevel[secondWord];
string animal = thirdLevel[thirdWord];

Console.WriteLine(animal);
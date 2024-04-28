// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<int, string> dddDictionary = new Dictionary<int, string>()
{
    [61] = "Brasilia",
    [71] = "Salvador",
    [11] = "Sao Paulo",
    [21] = "Rio de Janeiro",
    [32] = "Juiz de Fora",
    [19] = "Campinas",
    [27] = "Vitoria",
    [31] = "Belo Horizonte"
};

int ddd = int.Parse(Console.ReadLine());

if (dddDictionary.TryGetValue(ddd, out string name))
{
    Console.WriteLine(name);
}
else
{
    Console.WriteLine("DDD nao cadastrado");
}
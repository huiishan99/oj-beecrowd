// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int t1 = int.Parse(inputs[0]);
int t2 = int.Parse(inputs[1]);
int t3 = int.Parse(inputs[2]);
int t4 = int.Parse(inputs[3]);

int sum = t1 + t2 + t3 + t4 - 3;

Console.WriteLine(sum);
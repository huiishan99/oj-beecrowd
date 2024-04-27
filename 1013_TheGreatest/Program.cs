// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new char[] { ' ' });
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);
int C = int.Parse(inputs[2]);

int maiorAB = Math.Max(A, B);
int maior = Math.Max(maiorAB, C);

Console.WriteLine(maior + " eh o maior");
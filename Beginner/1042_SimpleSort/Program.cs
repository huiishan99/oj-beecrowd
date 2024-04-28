// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(' ');
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);
int C = int.Parse(inputs[2]);

int min = Math.Min(Math.Min(A, B), C);
int max = Math.Max(Math.Max(A, B), C);
int mid = A + B + C - min - max;

Console.WriteLine("{0}", min);
Console.WriteLine("{0}", mid);
Console.WriteLine("{0}", max);

Console.WriteLine();

Console.WriteLine("{0}", A);
Console.WriteLine("{0}", B);
Console.WriteLine("{0}", C);
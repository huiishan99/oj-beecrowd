// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);
int c = int.Parse(inputs[2]);
int d = int.Parse(inputs[3]);

int[] lenght = { a, b, c, d };
Array.Sort(lenght);

bool canFormTriangle = lenght[0] + lenght[1] > lenght[2] ||
                       lenght[0] + lenght[1] > lenght[3] ||
                       lenght[0] + lenght[2] > lenght[3] ||
                       lenght[1] + lenght[2] > lenght[3];

Console.WriteLine(canFormTriangle ? "S" : "N");
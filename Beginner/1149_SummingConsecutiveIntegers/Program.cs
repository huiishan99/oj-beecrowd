// See https://aka.ms/new-console-template for more information

using System.Linq;

string[] inputs = Console.ReadLine().Split();
int A = int.Parse(inputs[0]);
int N = 0;

foreach (var item in inputs.Skip(1))
{
    int current = int.Parse(item);
    if (current > 0)
    {
        N = current;
        break;
    }
}

int sum = 0;
for (int i = 0; i < N; i++)
{
    sum += A + i;
}

Console.WriteLine(sum);
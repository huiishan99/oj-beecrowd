// See https://aka.ms/new-console-template for more information

int X = int.Parse(Console.ReadLine());
int Z = 0;
int sum = 0;
int current = X;
int count = 0;

while (Z <= X)
{
    Z = int.Parse(Console.ReadLine());
}

while (sum <= Z)
{
    sum += current;
    current++;
    count++;
}

Console.WriteLine(count);
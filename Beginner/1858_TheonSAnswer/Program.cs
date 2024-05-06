// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int[] hits = new int[n];

for (int i = 0; i < n; i++)
{
    hits[i] = int.Parse(inputs[i]);
}

int minHits = hits[0];
int person = 1;
for (int i = 0; i < n; i++)
{
    if (minHits > hits[i])
    {
        minHits = hits[i];
        person = i + 1;
    }
}

Console.WriteLine(person);
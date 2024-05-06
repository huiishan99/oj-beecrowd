// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    string name = inputs[0];
    int newtons = int.Parse(inputs[1]);

    if (name == "Thor") Console.WriteLine("Y");
    else Console.WriteLine("N");
}
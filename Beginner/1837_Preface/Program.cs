// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

for (int r = 0; r < Math.Abs(b); r++)
{
    for (int q = -1000; q < 1000; q++)
    {
        if (a - r == b * q)
        {
            Console.WriteLine("{0} {1}", q, r);
            break;
        }
    }
}
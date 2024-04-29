// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());
int nextLine = 0;

for (int i = 0; i < N; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        if (j == 4)
        {
            Console.WriteLine("PUM");
        }
        else
        {
            Console.Write("{0} ", j + nextLine);
        }
    }

    nextLine += 4;
}
// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new char[]{' '});
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);
int C = int.Parse(inputs[2]);
int D = int.Parse(inputs[3]);

if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}
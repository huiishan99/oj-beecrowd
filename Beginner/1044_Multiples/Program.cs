// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new []{' '});
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    double A = double.Parse(inputs[0]);
    double B = double.Parse(inputs[1]);
    double C = double.Parse(inputs[2]);

    double weightA = A * 2.0;
    double weightB = B * 3.0;
    double weightC = C * 5.0;

    double average = (weightA + weightB + weightC) / 10.0;

    Console.WriteLine("{0:F1}", average);
}
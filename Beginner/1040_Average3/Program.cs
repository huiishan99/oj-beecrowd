// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
double N1 = double.Parse(inputs[0]);
double N2 = double.Parse(inputs[1]);
double N3 = double.Parse(inputs[2]);
double N4 = double.Parse(inputs[3]);

double weightN1 = N1 * 2.0;
double weightN2 = N2 * 3.0;
double weightN3 = N3 * 4.0;
double weightN4 = N4 * 1.0;

// 计算加权平均，然后四舍五入到一位小数
double average = Math.Round(((weightN1 + weightN2 + weightN3 + weightN4) / 10), 1);
Console.WriteLine("Media: {0:F1}", average);

if (average >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (average < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");

    double examScore = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota do exame: {0:F1}", examScore);

    double finalScore = (examScore + average) / 2;

    if (finalScore >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
    }

    Console.WriteLine("Media final: {0:F1}", finalScore);
}
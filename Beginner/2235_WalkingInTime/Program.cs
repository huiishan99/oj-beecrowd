// See https://aka.ms/new-console-template for more information

// 读取输入并解析成整数

string[] input = Console.ReadLine().Split(new[] { ' ' });
int A = int.Parse(input[0]);
int B = int.Parse(input[1]);
int C = int.Parse(input[2]);

// 检查是否可以通过一次旅行回到原点
if (A == 0 || B == 0 || C == 0)
{
    Console.WriteLine("S");
    return;
}

// 检查两次旅行的所有组合
if (Math.Abs(A - B) == 0 || Math.Abs(A - C) == 0 || Math.Abs(B - C) == 0)
{
    Console.WriteLine("S");
    return;
}

// 检查三次旅行的所有组合
if (Math.Abs(A - B - C) == 0 || Math.Abs(A - C - B) == 0 || Math.Abs(B - A - C) == 0 ||
    Math.Abs(B - C - A) == 0 || Math.Abs(C - A - B) == 0 || Math.Abs(C - B - A) == 0 ||
    Math.Abs(A + B - C) == 0 || Math.Abs(A + C - B) == 0 || Math.Abs(B + C - A) == 0)
{
    Console.WriteLine("S");
    return;
}

// 如果所有组合都不能回到原点，则输出'N'
Console.WriteLine("N");
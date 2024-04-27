// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

int remaining = N;

int[] denominations = { 100, 50, 20, 10, 5, 2, 1 };

Console.WriteLine(N);

// 遍历每种钞票面额
foreach (int denomination in denominations)
{
    // 计算当前面额的钞票数量
    int count = remaining / denomination;
    // 计算剩余金额
    remaining %= denomination;
    // 输出钞票面额和数量
    Console.WriteLine("{0} nota(s) de R$ {1},00", count, denomination);
}
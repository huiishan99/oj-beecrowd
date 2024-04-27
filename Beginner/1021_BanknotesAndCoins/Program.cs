// See https://aka.ms/new-console-template for more information

double N = double.Parse(Console.ReadLine());

// 将金额转换为整数处理（以最小单位计，即分），为避免精度问题，先进行四舍五入。
int totalCents = (int)Math.Round(N * 100);

int[] noteDenominations = { 100, 50, 20, 10, 5, 2 };
int[] coinDenominations = { 100, 50, 25, 10, 5, 1 };

Console.WriteLine("NOTAS:");
// 遍历每种钞票面额
foreach (int denomination in noteDenominations)
{
    // 计算当前面额的钞票数量
    int count = totalCents / (denomination * 100);
    // 计算剩余金额
    totalCents %= denomination * 100;
    // 输出钞票面额和数量
    Console.WriteLine("{0} nota(s) de R$ {1}.00", count, denomination);
}

Console.WriteLine("MOEDAS:");
// 遍历每种硬币面额
foreach (int denomination in coinDenominations)
{
    // 计算当前面额的硬币数量
    int count = totalCents / denomination;
    // 计算剩余金额
    totalCents %= denomination;
    // 输出硬币面额和数量
    Console.WriteLine("{0} moeda(s) de R$ {1:F2}", count, (denomination / 100.0));
}
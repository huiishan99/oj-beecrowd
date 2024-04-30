// See https://aka.ms/new-console-template for more information

int L = int.Parse(Console.ReadLine());  // 读取行号
char T = char.Parse(Console.ReadLine());  // 读取操作类型 'S' 或 'M'
double[,] M = new double[12, 12];  // 创建一个12x12的二维数组

// 填充数组
for (int i = 0; i < 12; i++)
{
    for (int j = 0; j < 12; j++)
    {
        M[i, j] = double.Parse(Console.ReadLine());  // 读取每个元素
    }
}

double sum = 0;  // 用于存储和或平均值计算的变量
for (int j = 0; j < 12; j++)
{
    sum += M[L, j];  // 累加第L行的所有元素
}

if (T == 'M')
{
    sum /= 12;  // 如果是求平均，除以列的数量
}

Console.WriteLine($"{sum:F1}");  // 输出结果，保留一位小数
// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine()); // 读取数组的大小
string[] input = Console.ReadLine().Split(); // 读取数组元素的字符串并分割
int[] X = new int[N]; // 创建数组

for (int i = 0; i < N; i++)
{
    X[i] = int.Parse(input[i]); // 将输入的字符串转换为整数并填充数组
}

int minValue = X[0]; // 假设第一个元素是最小的
int minPosition = 0; // 最小值的位置

for (int i = 1; i < N; i++) // 从第二个元素开始遍历
{
    if (X[i] < minValue) // 如果找到更小的值
    {
        minValue = X[i]; // 更新最小值
        minPosition = i; // 更新最小值的位置
    }
}

// 输出最小值及其位置
Console.WriteLine("Menor valor: " + minValue);
Console.WriteLine("Posicao: " + minPosition);
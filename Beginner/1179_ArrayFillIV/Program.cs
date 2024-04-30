// See https://aka.ms/new-console-template for more information

int[] impar = new int[5];
int[] par = new int[5];
int countImpar = 0, countPar = 0;

for (int i = 0; i < 15; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0) // 判断偶数
    {
        par[countPar] = num;
        countPar++;
        if (countPar == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"par[{j}] = {par[j]}");
            }
            countPar = 0; // 重置偶数数组
        }
    }
    else // 奇数
    {
        impar[countImpar] = num;
        countImpar++;
        if (countImpar == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"impar[{j}] = {impar[j]}");
            }
            countImpar = 0; // 重置奇数数组
        }
    }
}

// 打印剩余的奇数
for (int i = 0; i < countImpar; i++)
{
    Console.WriteLine($"impar[{i}] = {impar[i]}");
}

// 打印剩余的偶数
for (int i = 0; i < countPar; i++)
{
    Console.WriteLine($"par[{i}] = {par[i]}");
}
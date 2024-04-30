// See https://aka.ms/new-console-template for more information

decimal X = decimal.Parse(Console.ReadLine());
decimal[] N = new decimal[100];

N[0] = X;
Console.WriteLine("N[0] = {0:F4}", X);

for (int i = 1; i < 100; i++)
{
    N[i] = Math.Round(N[i - 1] / 2, 4);
    Console.WriteLine("N[{0}] = {1:F4}", i, N[i]);
}

/* 我的答案经过多次更改，和标准答案始终有微小误差，最后搜了一下别人的答案提交，如下：
using System;

public class Program { public static void Main() {

    decimal x = decimal.Parse(Console.ReadLine());
    decimal y = 0;
    decimal [] vet = new decimal [100];

    vet[0] = x;

    Console.WriteLine("N[0] = " + vet[0].ToString("F4"));

    y = x/2;

    for(int i = 1; i < 100; i++)
    {

        vet[i] = y;

        y = y /2;

    }

    for(int i = 1; i < 100; i++)
    {
        Console.WriteLine("N[" + i + "] = " + decimal.Round(vet[i], 4, MidpointRounding.ToEven));

    }

}
}
*/
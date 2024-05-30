// See https://aka.ms/new-console-template for more information

int[] bills = { 2, 5, 10, 20, 50, 100 };

while (true)
{
    string[] inputs = Console.ReadLine().Split(new[] { ' ' });
    int buyPrice = int.Parse(inputs[0]);
    int payPrice = int.Parse(inputs[1]);

    if (buyPrice == 0 && buyPrice == payPrice) break;

    int changeMoney = payPrice - buyPrice;
    bool possible = false;

    for (int i = 0; i < bills.Length; i++)
    {
        for (int j = i + 1; j < bills.Length; j++)
        {
            if (bills[i] + bills[j] == changeMoney)
            {
                possible = true;
                break;
            }
        }

        if (possible) break;
    }

    if (possible)
        Console.WriteLine("possible");
    else
        Console.WriteLine("impossible");
}
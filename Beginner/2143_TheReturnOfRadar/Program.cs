// See https://aka.ms/new-console-template for more information

while (true)
{
    int testCases = int.Parse(Console.ReadLine());
    if (testCases == 0) break;

    for (int i = 0; i < testCases; i++)
    {
        int orders = 0;
        int peopleNumber = int.Parse(Console.ReadLine());

        if (peopleNumber % 2 == 0)
        {
            orders = (peopleNumber - 2) * 2 + 2;
            Console.WriteLine(orders);
        }
        else
        {
            orders = (peopleNumber - 1) * 2 + 1;
            Console.WriteLine(orders);
        }
    }
}
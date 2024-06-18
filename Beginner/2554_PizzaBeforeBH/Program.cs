// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] testCase = line.Split(new[] { ' ' });
    int n = int.Parse(testCase[0]);
    int d = int.Parse(testCase[1]);

    bool evetHappen = false;
    for (int i = 0; i < d; i++)
    {
        string[] dateInput = Console.ReadLine().Split(new[] { ' ' });
        string date = dateInput[0];

        int count = 0;
        for (int j = 1; j <= n; j++)
        {
            if (dateInput[j] == "1")
            {
                count++;
            }
        }

        if (count == n)
        {
            if (evetHappen == false)
            {
                Console.WriteLine(date);
            }

            evetHappen = true;
        }
    }

    if (evetHappen == false)
    {
        Console.WriteLine("Pizza antes de FdI");
    }
}
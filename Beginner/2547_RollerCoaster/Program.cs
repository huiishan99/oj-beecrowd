// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] testCase = line.Split(new[] { ' ' });
    int n = int.Parse(testCase[0]);
    int aMin = int.Parse(testCase[1]);
    int aMax = int.Parse(testCase[2]);

    int count = 0;
    for (int i = 0; i < n; i++)
    {
        int height = int.Parse(Console.ReadLine());
        if (height >= aMin && height <= aMax)
        {
            count++;
        }
    }

    Console.WriteLine(count);
}
// See https://aka.ms/new-console-template for more information

string input;

while ((input = Console.ReadLine()) != null)
{
    int recordNum = int.Parse(input);

    double fastAverageSpeed = 0;
    for (int i = 0; i < recordNum; i++)
    {
        string[] record = Console.ReadLine().Split(new[] { ' ' });
        int duration = int.Parse(record[0]);
        int distance = int.Parse(record[1]);

        if (i == 0)
        {
            Console.WriteLine("1");
            fastAverageSpeed = distance * 1.0 / duration;
        }
        else
        {
            double newAverageSpeed = distance * 1.0 / duration;
            if (newAverageSpeed > fastAverageSpeed)
            {
                fastAverageSpeed = newAverageSpeed;
                Console.WriteLine(i + 1);
            }
        }
    }
}
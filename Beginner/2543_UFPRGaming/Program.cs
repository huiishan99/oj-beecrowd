// See https://aka.ms/new-console-template for more information

string line;

while ((line = Console.ReadLine()) != null)
{
    string[] input = line.Split(new[] { ' ' });
    int number = int.Parse(input[0]);
    int studentId = int.Parse(input[1]);

    int count = 0;
    for (int i = 0; i < number; i++)
    {
        string[] checkInput = Console.ReadLine().Split(new[] { ' ' });
        int checkStudentId = int.Parse(checkInput[0]);
        int playType = int.Parse(checkInput[1]);
        if (checkStudentId == studentId && playType == 0)
        {
            count++;
        }
    }

    Console.WriteLine(count);
}
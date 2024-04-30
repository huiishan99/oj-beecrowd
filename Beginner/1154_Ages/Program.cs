// See https://aka.ms/new-console-template for more information

int sum = 0;
int count = 0;

while (true)
{
    int age = int.Parse(Console.ReadLine());
    if (age < 0) break;
    sum = sum + age;
    count++;
}

double average = sum * 1.0 / count;

Console.WriteLine("{0:F2}", average);
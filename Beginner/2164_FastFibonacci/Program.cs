// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

double fibonacci = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) -
                    Math.Pow((1 - Math.Sqrt(5)) / 2, n))
                   / Math.Sqrt(5);

Console.WriteLine($"{fibonacci:F1}");
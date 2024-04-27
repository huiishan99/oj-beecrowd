// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

int hours = N / 3600; // 一小时3600秒
int remainingSeconds = N % 3600;
int minutes = remainingSeconds / 60;
int seconds = remainingSeconds % 60;

Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
// See https://aka.ms/new-console-template for more information

string[] startDayLine = Console.ReadLine().Split(new[] { ' ' });
int startDay = int.Parse(startDayLine[1]);

string[] startTimeLine = Console.ReadLine().Split(new[] { ':' });
int startHour = int.Parse(startTimeLine[0]);
int startMinute = int.Parse(startTimeLine[1]);
int startSecond = int.Parse(startTimeLine[2]);

string[] endDayLine = Console.ReadLine().Split(new[] { ' ' });
int endDay = int.Parse(endDayLine[1]);

string[] endTimeLine = Console.ReadLine().Split(new[] { ':' });
int endHour = int.Parse(endTimeLine[0]);
int endMinute = int.Parse(endTimeLine[1]);
int endSecond = int.Parse(endTimeLine[2]);

int startTotalSeconds = (startDay * 86400) + (startHour * 3600) + (startMinute * 60) + startSecond;
int endTotalSeconds = (endDay * 86400) + (endHour * 3600) + (endMinute * 60) + endSecond;

int durationSeconds = endTotalSeconds - startTotalSeconds;

int durationDays = durationSeconds / 86400;
durationSeconds = durationSeconds % 86400;
int durationHours = durationSeconds / 3600;
durationSeconds = durationSeconds % 3600;
int durationsMinutes = durationSeconds / 60;
durationSeconds = durationSeconds % 60;

Console.WriteLine("{0} dia(s)", durationDays);
Console.WriteLine("{0} hora(s)", durationHours);
Console.WriteLine("{0} minuto(s)", durationsMinutes);
Console.WriteLine("{0} segundo(s)", durationSeconds);
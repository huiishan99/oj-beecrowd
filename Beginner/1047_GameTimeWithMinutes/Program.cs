// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int startHour = int.Parse(inputs[0]);
int startMinute = int.Parse(inputs[1]);
int endHour = int.Parse(inputs[2]);
int endMinute = int.Parse(inputs[3]);

int durationHours = endHour - startHour;
int durationMinutes = endMinute - startMinute;

if (durationMinutes < 0)
{
    durationMinutes += 60;
    durationHours--;
}

if (durationHours < 0 || (durationHours == 0 && durationMinutes == 0))
{
    durationHours += 24;
}

Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", durationHours, durationMinutes);
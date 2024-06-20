// See https://aka.ms/new-console-template for more information

string line;

int countSalida = 0;
int countVuelta = 0;
int countGoTourists = 0;
int countReturnTourists = 0;

while ((line = Console.ReadLine()) != "ABEND")
{
    string[] inputs = line.Split(new[] { ' ' });
    string jeepMove = inputs[0];
    int numberTourists = int.Parse(inputs[1]);

    if (jeepMove == "SALIDA")
    {
        countSalida++;
        countGoTourists += numberTourists;
    }
    else
    {
        countVuelta++;
        countReturnTourists += numberTourists;
    }
}

int amountTourists = countGoTourists - countReturnTourists;
int amountJeeps = countSalida - countVuelta;

Console.WriteLine(amountTourists);
Console.WriteLine(amountJeeps);
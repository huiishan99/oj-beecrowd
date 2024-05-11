// See https://aka.ms/new-console-template for more information

string[] inputs = Console.ReadLine().Split(new[] { ' ' });
int jumpHeight = int.Parse(inputs[0]);
int numberOfPipes = int.Parse(inputs[1]);

string[] heightStrings = Console.ReadLine().Split(' ');
int[] pipeHeights = new int[numberOfPipes];

for (int i = 0; i < numberOfPipes; i++)
{
    pipeHeights[i] = int.Parse(heightStrings[i]);
}

bool canWin = true;
for (int i = 0; i < numberOfPipes - 1; i++)
{
    if (Math.Abs(pipeHeights[i] - pipeHeights[i + 1]) > jumpHeight)
    {
        canWin = false;
        break;
    }
}

if (canWin) Console.WriteLine("YOU WIN");
else Console.WriteLine("GAME OVER");
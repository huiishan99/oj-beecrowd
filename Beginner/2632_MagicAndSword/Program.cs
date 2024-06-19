// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Dictionary<string, Dictionary<int, int>> spellRadii = new Dictionary<string, Dictionary<int, int>>
{
    { "fire", new Dictionary<int, int> { { 1, 20 }, { 2, 30 }, { 3, 50 } } },
    { "water", new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 40 } } },
    { "earth", new Dictionary<int, int> { { 1, 25 }, { 2, 55 }, { 3, 70 } } },
    { "air", new Dictionary<int, int> { { 1, 18 }, { 2, 38 }, { 3, 60 } } },
};

Dictionary<string, int> spellDamages = new Dictionary<string, int>
{
    { "fire", 200 }, { "water", 300 }, { "earth", 400 }, { "air", 100 }
};

int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] line1 = Console.ReadLine().Split(new[] { ' ' });
    int w = int.Parse(line1[0]);
    int h = int.Parse(line1[1]);
    int x0 = int.Parse(line1[2]);
    int y0 = int.Parse(line1[3]);

    string[] line2 = Console.ReadLine().Split(new[] { ' ' });
    string spell = line2[0];
    int levelN = int.Parse(line2[1]);
    int cx = int.Parse(line2[2]);
    int cy = int.Parse(line2[3]);

    int radius = spellRadii[spell][levelN];
    int baseDamage = spellDamages[spell];

    if (IsRectangleIntersectingCircle(w, h, x0, y0, cx, cy, radius))
    {
        Console.WriteLine(baseDamage);
    }
    else
    {
        Console.WriteLine(0);
    }
}

static bool IsRectangleIntersectingCircle(int w, int h, int x0, int y0, int cx, int cy, int radius)
{
    int nearestX = Math.Max(x0, Math.Min(cx, x0 + w));
    int nearestY = Math.Max(y0, Math.Min(cy, y0 + h));
    int deltaX = cx - nearestX;
    int deltaY = cy - nearestY;
    return (deltaX * deltaX + deltaY * deltaY) <= (radius * radius);
}
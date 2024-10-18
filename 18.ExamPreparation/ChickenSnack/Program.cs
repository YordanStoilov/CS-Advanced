
using System;
using System.Collections.Generic;
using System.Linq;


Queue<int> armors = new Queue<int>(Console.ReadLine().Split(",", 
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> attacks = new Stack<int>(Console.ReadLine().Split(",",
    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

int killedMonsters = 0;

while (armors.Count > 0 && attacks.Count > 0)
{
    int armor = armors.Dequeue();
    int attack = attacks.Pop();
    int difference = attack - armor;

    if (difference >= 0)
    {
        killedMonsters++;
        if (difference == 0)
        {
            continue;
        }
        attack = difference;
        if (attacks.Count > 0)
        {
            attacks.Push(attacks.Pop() + difference);
        }
        else
        {
            attacks.Push(difference);
        }
    }
    else if (difference < 0)
    {
        armors.Enqueue(Math.Abs(difference));
    }
}

if (armors.Count <= 0)
{
    Console.WriteLine("All monsters have been killed!");
}
else if (attacks.Count <= 0)
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {killedMonsters}");
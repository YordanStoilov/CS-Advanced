
using System.Text;
StringBuilder text = new();
int n = int.Parse(Console.ReadLine());
Stack<StringBuilder> undoStack = new();
undoStack.Push(new StringBuilder());

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    string action = command[0];

    if (action == "1")
    {
        text.Append(command[1]);
    }
    else if (action == "2")
    {
        for (int j = 0; j < int.Parse(command[1]); j++)
        {
            text.Remove(text.Length - 1, 1);
        }
    }
    else if (action == "3")
    {
        char element = text.ToString()[int.Parse(command[1]) - 1];
        Console.WriteLine(element);
        continue;
    }
    else if (action == "4")
    {
        undoStack.Pop();
        text = undoStack.Pop();
    }
    undoStack.Push(new StringBuilder(text.ToString()));
}


using System.ComponentModel;

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Stack<string> operations = new Stack<string>();
int sum = 0;

foreach (string value in input)
{
    if (value == "+" | value == "-")
    {
        operations.Push(value);
        continue;
    }

    int addition = int.Parse(value);
    if (operations.Count > 0)
    {
        string currentOperation = operations.Pop();
        if (currentOperation == "-")
        {
            addition = 0 - int.Parse(value);
        }
    }

    sum += addition;

}

Console.WriteLine(sum);
string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    char character = input[i];
    if (character == '(')
    {
        stack.Push(i);
    }
    else if (character == ')')
    {
        int start = stack.Pop();
        Console.WriteLine(input.Substring(start, i - start + 1));
    }
}
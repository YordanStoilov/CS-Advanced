int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string command = input[0];

    switch (command)
    {
        default:
            break;

        case "1":
            int num = int.Parse(input[1]);
            stack.Push(num);
            break;

        case "2":
            stack.Pop();
            break;

        case "3":
            if (stack.Count > 0)
            {
                Console.WriteLine(stack.Max());
            }
            break;

        case "4":
            if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            break;
    }
}
Console.WriteLine(String.Join(", ", stack));
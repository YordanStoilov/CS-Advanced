
Stack<int> stack = new Stack<int>();
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int toPush = nums[0], toPop = nums[1], toLookFor = nums[2];
int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int endFirstLoop = Math.Min(toPush, numArray.Length);
for (int i = 0; i < endFirstLoop; i++)
{
    stack.Push(numArray[i]);
}

int endSecondLoop = Math.Min(toPop, stack.Count);
for (int i = 0; i < endSecondLoop; i++)
{
    stack.Pop();
}

if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else if (stack.Contains(toLookFor))
{
    Console.WriteLine("true");
}
else
{
    List<int> smallestNum = stack.ToList();
    smallestNum.Sort((num1, num2) => num1.CompareTo(num2));
    Console.WriteLine(smallestNum[0]);
}
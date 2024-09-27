
namespace ImplementingCustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Console.WriteLine(stack);
        }
    }
}

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
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
            
        }
    }
}
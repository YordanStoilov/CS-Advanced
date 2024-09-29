
using GenericBoxOfString;
namespace GenericBoxOfInteger
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(box);
        }
    }
}
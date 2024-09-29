using System.Runtime.CompilerServices;

namespace GenericCountMethodString
{
    class Program
    {
        static void Main()
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            string stringToCompare = Console.ReadLine();

            Console.WriteLine(box.FindCountOfElementsWIthBiggerValue(stringToCompare));
        }
    }
}
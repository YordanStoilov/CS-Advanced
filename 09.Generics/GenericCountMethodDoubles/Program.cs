using System.Runtime.CompilerServices;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main()
        {
            Box<double> box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double numToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.FindCountOfElementsWIthBiggerValue(numToCompare));
        }
    }
}
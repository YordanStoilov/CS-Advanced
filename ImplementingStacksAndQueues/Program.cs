
namespace ImplementingStacksAndQueues
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.InsertAt(1, 5);
            Console.WriteLine(list);
        }
    }
}
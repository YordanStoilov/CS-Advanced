namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();

            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.ForEach(x => Console.WriteLine($"ForEach -> {x}"));

            Console.WriteLine('\n');
            foreach (int num in linkedList.ToArray())
            {
                Console.WriteLine($"ToArray -> {num}");
            }
        }
    }
}
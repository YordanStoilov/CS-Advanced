namespace CustomLinkedList;

public class Program
{
    static void Main(string[] args)
    {
        CustomLinkedList<int> list = new CustomLinkedList<int>();

        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddLast(4);
        list.RemoveFirst();
        list.RemoveLast();

        foreach (int i in list)
            Console.WriteLine(i);
    }
}
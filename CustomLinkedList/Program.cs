namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            Node node = linkedList.Head;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }
    }
}
namespace CustomLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();

            linkedList.RemoveLast();
            Node node = linkedList.Head;

            Console.WriteLine($"Length -> {linkedList.Length}\n");
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }
    }
}
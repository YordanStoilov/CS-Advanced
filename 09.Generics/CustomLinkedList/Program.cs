
namespace CustomDoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomDoublyLinkedList<string> list = new();

            list.AddFirst("Pesho");
            list.AddFirst("Tosho");
            list.AddFirst("Gosho");
            list.AddFirst("Grisho");
            list.RemoveFirst();
            
            Console.WriteLine(list);
        }
    }
}

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; }

        public CustomDoublyLinkedList()
        {
            Reset();
        }
        public void Reset()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddFirst(T value)
        {
            Node<T> newHead = new Node<T>(value);
            if (Head == null || Count == 0)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            Node<T> newTail = new Node<T>(value);

            if (Head == null || Count == 0)
            {
                Head = newTail;
                Tail = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count <= 0)
            {
                Reset();
                throw new InvalidOperationException("The list is empty");
            }
            T firstElement = Head.Value;

            Head = Head.Next;

            if (Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                Tail = null;
            }

            Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (Count <= 0)
            {
                Reset();
                throw new InvalidOperationException("The list is empty");
            }

            T lastElement = Tail.Value;
            Tail = Tail.Previous;

            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }

            Count--;
            return lastElement;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];

            int index = 0;
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.Next;
                index++;
            }
            return array;
        }
        public override string ToString()
        {
            List<T> sb = new List<T>();
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                sb.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }
            string result = string.Join(", ", sb);
            return result;
        }
    }
}

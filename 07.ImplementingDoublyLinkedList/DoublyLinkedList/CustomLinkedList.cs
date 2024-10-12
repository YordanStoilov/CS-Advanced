using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Length { get; set; }

        public CustomLinkedList()
        {
            Reset();
        }
        public void Reset()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            Length++;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            Length++;

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }

        public void RemoveFirst()
        {
            Length--;
            if (Length <= 0)
            {
                Reset();
                return;
            }
            var ptr = Head.Next;
            ptr.Previous = null;
            Head.Next = null;
            Head = ptr;
        }

        public void RemoveLast()
        {
            Length--;
            if (Length <= 0)
            {
                Reset();
                return;
            }
            var ptr = Tail.Previous;
            ptr.Next = null;
            Tail.Previous = null;
            Tail = ptr;
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
            T[] array = new T[Length];

            int index = 0;
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                array[index++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = Head;

            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

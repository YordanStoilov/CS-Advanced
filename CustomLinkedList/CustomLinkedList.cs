using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public CustomLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

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

        public void AddLast(int value)
        {
            Node newNode = new Node();

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            Tail.Next = newNode;
            newNode.Previous = Tail;
            newNode.Value = value;
            Tail = newNode;
        }
        //Possible errors here
        public void RemoveFirst()
        {
            var ptr = Head.Next;
            ptr.Previous = null;
            Head.Next = null;
            Head = ptr;
        }
        //And here
        //With the pointer ptr:
        public void RemoveLast()
        {
            var ptr = Tail.Previous;
            ptr.Next = null;
            Tail.Previous = null;
            Tail = ptr;
        }
    }
}

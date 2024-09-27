using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingCustomQueue
{
    public class CustomQueue
    {
        private int[] items;
        private const int FirstElementIndex = 0;
        private const int InitialCapacity = 4;
        public int Count { get; private set; } = 0;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }

        public void Enqueue(int value)
        {
            if (Count == items.Length)
            {
                IncreaseSize();
            }
            items[Count] = value;
            Count++;
        }

        public int Dequeue()
        {
            if (Count <= 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int firstElement = items[FirstElementIndex];

            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            Count--;

            return firstElement;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidCastException();
            }
            return items[FirstElementIndex];
        }

        public void Clear()
        {
            items = new int[InitialCapacity];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
        private void IncreaseSize()
        {
            int[] newArray = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
        private void DecreaseSize()
        {
            int[] newArray = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                if (i < Count - 1)
                {
                    sb.Append($"{items[i]}, ");
                }
                else
                {
                    sb.Append($"{items[i]}");
                }
            }
            return sb.ToString();
        }
    }
}

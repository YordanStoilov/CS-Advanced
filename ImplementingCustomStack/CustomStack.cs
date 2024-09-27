using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingCustomStack
{
    public class CustomStack
    {
        private int[] items;
        private const int InitialCapacity = 4;
        public int Count { get; private set; } = 0;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }

        public void Push(int value)
        {
            if (Count == items.Length)
            {
                IncreaseSize();
            }
            items[Count] = value;
            Count++;
        }

        public int Pop()
        {
            if (Count <= 0)
            {
                throw new InvalidOperationException("Stack is Empty!");
            }

            int value = items[Count - 1];
            items[Count - 1] = default;
            Count--;

            if (Count < items.Length / 4)
            {
                DecreaseSize();
            }
            return value;
        }
        public int Peek()
        {
            return items[Count - 1];
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

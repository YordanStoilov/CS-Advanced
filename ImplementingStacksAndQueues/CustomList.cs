using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStacksAndQueues
{
    public class CustomList
    {
        private int[] items;
        private int ArrayInitialSize = 2;
        public int Count { get; private set; } = 0;
        public CustomList()
        {
            items = new int[ArrayInitialSize];
        }
        public void Add(int element)
        {
            if (Count >= items.Length)
            {
                IncreaseSize();
            }
            items[Count] = element;
            Count++;
        }
        public int RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range for the List!");
            }

            int[] newArray = new int[items.Length];
            int num = 0;

            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                {
                    num = items[i];
                }
                else if (i < index)
                {
                    newArray[i] = items[i];
                }
                else
                {
                    newArray[i - 1] = items[i];
                }
            }
            items = newArray;
            Count--;
            return num;
        }
        public bool Contains(int item)
        {
            for (int i = 0; i < Count; ++i)
            {
                if (items[i] == item)
                    return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= Count || index2 < 0 || index2 >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of bounds for the List!");
            }

            int temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
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
    }
}

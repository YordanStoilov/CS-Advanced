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
            return num;
        }
        public void Contains(int item)
        {

        }

        public void Swap(int index1, int index2)
        {

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

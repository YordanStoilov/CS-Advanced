using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingCustomList
{
    public class CustomList
    {
        private int[] items;
        private int ArrayInitialSize = 2;
        public int Count { get; private set; } = 0;
        public int this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                items[index] = value;
            }
        }
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

            int num = items[index];

            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            Count--;
            if (Count <= items.Length / 4)
            {
                DecreaseSize();
            }
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
            if (index1 < 0 || index1 >= Count 
                || index2 < 0 || index2 >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of bounds for the List!");
            }

            int temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
        public void InsertAt(int index, int value)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (Count >= items.Length)
            {
                IncreaseSize();
            }

            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = value;
            Count++;
            
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

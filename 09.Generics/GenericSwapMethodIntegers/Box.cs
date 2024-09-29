﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T).ToString()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Swap(int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}

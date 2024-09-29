using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    internal class Box<T>
    {
        private Stack<T> list;
        public int Count {
            get
            {
                return list.Count;
            }
        }

        public Box()
        {
            list = new Stack<T>();
        }
        public void Add(T element)
        {
            list.Push(element);
        }

        public T Remove()
        {
            return list.Pop();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack;
public class CustomStack<T> :IEnumerable<T>
{
    public List<T> Items { get; set; }

    public CustomStack()
    {
        Items = new List<T>();
    }
    public void Push(T item)
    {
        Items.Add(item);    
    }
    public T Pop()
    {
        if (Items.Count == 0)
        {
            throw new InvalidOperationException();
        }


        T itemToReturn = Items[Items.Count - 1];
        Items.RemoveAt(Items.Count - 1);

        return itemToReturn;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Items.Count - 1; i >= 0; i--)
        {
            yield return Items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

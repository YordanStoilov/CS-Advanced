using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator;
public class ListyIterator<T> : IEnumerable<T>
{
    public List<T> Contents { get; set; }
    public int Index { get; set; }

    public ListyIterator(List<T> contents)
    {
        Contents = contents;
        Index = 0;
    }

    public bool Move()
    {
        if (HasNext())
        {
            Index++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        return Index < Contents.Count - 1;
    }
    
    public void Print()
    {
        if (Contents.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(Contents[Index]);
        }
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ", Contents));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Contents.Count; i++)
        {
            yield return Contents[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;
public class Library : IEnumerable<Book>
{
    private List<Book>? Books;

    public Library(params Book[] books)
    {
        Books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        for (int i = 0; i < Books.Count; i++)
        {
            yield return Books[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

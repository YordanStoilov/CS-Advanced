using System;
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
        Books.Sort();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(Books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    class LibraryIterator : IEnumerator<Book>
    {
        private int CurrentIndex;
        private List<Book> Books;

        public LibraryIterator(List<Book> books)
        {
            Books = books;
            Reset();
        }

        public Book Current => this.Books[CurrentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext() => ++this.CurrentIndex < this.Books.Count;

        public void Reset() => this.CurrentIndex = -1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Library
{
    class Library
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Book> books;
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public Library(string name)
        {
            this.name = name;
            this.books = new List<Book>();
        }
        public Library(string name, List<Book> books)
        {
            this.name = name;
            this.books = books;
        }
        
        public void AddBook(params Book[] books)
        {
            this.books.InsertRange(this.books.Count,books);
        }
        public void DeleteBook(Book book)
        {
            this.books.Remove(book);            
        }

        public List<Book> Search(string title,string author)
        {
            return (List<Book>)this.books.Where((x) => { return x.Title == title && x.Author == author; });
        }

        public string FormatPrintBooks()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in this.books)
            {
                str.Append(String.Format("{0} {1}", item.Title, item.Author)+"\r\n");
            }
            return str.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Library
{
    class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private int publishYear;

        public int PublishYear
        {
            get { return publishYear; }
            set { publishYear = value; }
        }

        private string isbn;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Book(string author, string title, string publisher, string isbn)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.isbn = isbn;
        }
        public Book(string author, string title, string publisher, string isbn, int publishYear)
            : this(author, title, publisher, isbn)
        {
            this.publishYear = publishYear;
        }
    }
}

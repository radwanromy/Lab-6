﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Book
    {
        string bookName;
        public string BookName
        {
            set { bookName = value; }
            get { return bookName; }
        }
        private string bookAuthor;
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public Book()
        {
            Console.WriteLine("Student Default");
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            Console.WriteLine("Book Valued Constructor");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Book Author: " + bookAuthor);
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Book Type : " + bookType);
        }

    }
}
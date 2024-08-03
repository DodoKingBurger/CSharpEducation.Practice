using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task11
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //11.Создай класс "Книга" с полями "Название" и "Автор".Напиши метод, который будет
      //принимать объект класса "Книга" и возвращать информацию о книге в виде строки
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Book Niga = new Book();
      Book Niga2 = new Book("CLR via C#");
      Book Niga3 = new Book("CLR via C#", "Джеффри Рихтер");

      WhatTheBook(Niga);
      WhatTheBook(Niga2);
      WhatTheBook(Niga3);
      void WhatTheBook(Book book)
      {
        Console.WriteLine($"Название книги: {book.BookName}");
        Console.WriteLine($"Кто написал: {book.AuthorName}");
      }
    }
    class Book
    {
      private string bookName;
      private string authorName;
      public string BookName
      {
        get
        {
          return bookName;
        }
        set
        {
          this.bookName = value;
        }
      }
      public string AuthorName
      {
        get
        {
          return this.authorName;
        }
        set
        {
          this.authorName = value;
        }
      }
      public Book(string BookName)
      {
        if (BookName != null)
        {
          this.bookName = BookName;
        }
        else
        {
          this.bookName = "Неизвестно";
        }
        this.authorName = "Неизвестно";
      }
      public Book(string BookName, string AuthorName)
      {
        if (BookName != null)
        {
          this.bookName = BookName;
        }
        else
        {
          this.bookName = "Неизвестно";
        }
        if (AuthorName != null)
        {
          this.authorName = AuthorName;
        }
        else
        {
          this.authorName = "Неизвестно";
        }
      }
      public Book()
      {
        this.bookName = "Неизвестно";
        this.authorName = "Неизвестно";
      }
    }
  }
}

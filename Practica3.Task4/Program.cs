using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай класс "Книга" с полями "Название" и "Автор".Реализуй два конструктора:
//один с параметрами для инициализации полей, другой без параметров, который
//будет устанавливать значения по умолчанию.

      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Book Niga = new Book();
      Book book = new Book("CLR via C#","Джеффри Рихтер");
      Niga.WhatTheBook();
      book.WhatTheBook();
    }
    class Book
    {
      private string bookName;
      private string authorName;
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
      public void WhatTheBook()
      {
        Console.WriteLine($"Название книги: {this.bookName}");
        Console.WriteLine($"Кто написал: {this.authorName}");
      }
    }
  }
}

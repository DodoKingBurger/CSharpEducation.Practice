using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай класс "Книга" с полями "Название" и "Автор".Реализуй два конструктора:
//один с параметрами для инициализации полей, другой без параметров, который
//будет устанавливать значения по умолчанию.Расширь класс "Книга" из
//предыдущего задания, добавив поле "Год издания".Реализуй цепочку
//конструкторов так, чтобы можно было создавать объекты класса "Книга" с
//указанием только названия, названия и автора, или всех трех полей.

      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Book Niga = new Book();
      Book book = new Book("CLR via C#");
      Book book2 = new Book("CLR via C#", "Джеффри Рихтер");
      Book book3= new Book("CLR via C#", "Джеффри Рихтер",2024);
      Niga.WhatTheBook();
      book.WhatTheBook();
      book2.WhatTheBook();
      book3.WhatTheBook();
    }
    class Book
    {
      private string bookName;
      private string authorName;
      private string yearOfPublic;
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
        this.yearOfPublic = "Неизвестно";
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
        this.yearOfPublic = "Неизвестно";
      }
      public Book()
      {
        this.bookName = "Неизвестно";
        this.authorName = "Неизвестно";
        this.yearOfPublic = "Неизвестно";
      }
      public Book(string BookName, string AuthorName, int YearOfPublic)
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
        if (YearOfPublic != null)
        {
          this.yearOfPublic = $"{YearOfPublic}";
        }
        else
        {
          this.yearOfPublic = "Неизвестно";
        }
      }
      public void WhatTheBook()
      {
        Console.WriteLine($"Название книги: {this.bookName}");
        Console.WriteLine($"Кто написал: {this.authorName}");
        Console.WriteLine($"Год издания: {this.yearOfPublic}");
      }
    }
  }
}

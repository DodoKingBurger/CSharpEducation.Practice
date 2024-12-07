using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Task3
{
  internal class Book : IComparable
  {
    public string Title;
    public string Author;

    public int CompareTo(object? obj)
    {
      if (obj is Book book) 
        return this.Title.CompareTo(book.Title);
      else
        throw new ArgumentException("Неизвестный Тип для сравнения");
    }
  }
}

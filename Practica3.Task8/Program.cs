using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task8
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      . Cоздай структуру "Прямоугольник" с полями "Ширина" и "Высота" типа double.
//Напиши метод, который будет вычислять площадь прямоугольника
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Rectangle box = new Rectangle();
      box.width = 10;
      box.height = 10;
      box.Square();
    }
    public struct Rectangle
    {
      private double Width;
      private double Height;
      public double width { get { return Width; } set { Width = value; } }
      public double height { get { return Height; } set { Height = value; } }

      public void Square()
      {
        Console.WriteLine($"Площадь прямоуголльника: {Width * Height}");
      }
    }
  }
}

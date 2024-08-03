using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай структуру "Точка" с полями "X" и "Y" типа int.Напиши метод, который будет
//принимать две точки и возвращать расстояние между ними
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Point First = new Point();
      Point Second = new Point();
      First.x = -4;
      First.y = -1;
      Second.x = 8;
      Second.y = 7;
      Console.WriteLine($"Расстояние между ними: {Distance(First,Second)}");    

      float Distance(Point first, Point second)
      {
        float distance;
        distance = (float)Math.Sqrt(Math.Pow(First.x - Second.x, 2) + Math.Pow(First.y - Second.y, 2));
        return distance;
      }
    }
    public struct Point
    {
      private int X;
      private int Y;
      public int x { get { return X; } set {  X = value; } }
      public int y { get { return Y; } set { Y = value; } }

    }      

  }
}

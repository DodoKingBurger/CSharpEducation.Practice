using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practics._3._2.Task1;
namespace Practics._3._2.Task2
{
  internal class Program
  {
    //2.	Создай новый проект и подключи к нему библиотеку классов,
    //созданную в предыдущем задании.Используй методы из класса "MathHelper"
    //для выполнения простых математических операций в этом проекте.
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      MathHelper mathHelper = new MathHelper();
      Console.WriteLine(mathHelper.Sum(1, 1));
      Console.WriteLine(mathHelper.Multiplay(2, 2));
      Console.WriteLine(mathHelper.Divide(3, 3));
      Console.WriteLine(mathHelper.Divide(4, 0));
      Console.WriteLine(mathHelper.Subtract(4, 4));
    }
  }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ListStorage<string> list = new ListStorage<string>();
      try
      {
        while (true) 
        {
          Console.WriteLine("Привет!\n" +
          "1. Добавить в список продукт\n" +
          "2. Найти продукт по индексу " +
          "3. Сколько в списке пунктов");
          string Vopros = Console.ReadLine();
          if (!int.TryParse(Vopros, out int result))
            throw new ArithmeticException("Запрос не ясен");
          switch (result)
          {
            case 1:
              string Otvet = Console.ReadLine();
              if (!string.IsNullOrEmpty(Otvet))
              {
                list.Add(Otvet);
              }
              else
                throw new ArgumentNullException("Добавленный продукт пуст");
              break;
            case 2:
              string OtvetIndex = Console.ReadLine();
              if (!string.IsNullOrEmpty(OtvetIndex)&& int.TryParse(OtvetIndex,out int IndexGet))
              {
                Console.WriteLine(list.Get(IndexGet));
              }
              else
                throw new ArgumentException("Добавленный продукт пуст");
              break;
            case 3:
              Console.WriteLine($"{list.Count}");
              break;
            default:
              continue;
          }
        }
      }
      catch(Exception ex) 
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}

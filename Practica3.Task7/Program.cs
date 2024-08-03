using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task7
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай перечисление "Месяцы" с элементами, представляющими названия
//месяцев года.Напиши метод, который будет принимать месяц и возвращать
//количество дней в этом месяце
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Console.Write($"Дней в месяце {Months.February} - {DaysInMonwhs(Months.February)}\n");
      int DaysInMonwhs(Months months)
      {
        switch (months)
        {
          case Months.January:
            return 31;

          case Months.February:
            return 28;

          case Months.March:
            return 31;

          case Months.April:
            return 30;

          case Months.May:
            return 31;

          case Months.June:
            return 30;

          case Months.July:
            return 31;

          case Months.August:
            return 31;

          case Months.September:
            return 30;

          case Months.October:
            return 31;

          case Months.November:
            return 30;

          case Months.December:
            return 31;

          default
            : return 0;
        }
      }
    }
    enum Months
    {
      January,
      February,  
      March,
      April, 
      May,
      June,
      July,
      August,
      September, 
      October,
      November, 
      December
    }
  }
}

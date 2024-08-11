using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practics3._2.Task3;
namespace Practics3._2.Task4
{
  internal class Program
  {
   // 3.	Создай библиотеку классов, в которой будет класс "Person" с полями "Имя" и "Возраст".
   // Реализуй метод, который будет выводить информацию о персоне в консоль.
   // Подключи эту пользовательскую библиотеку классов в новый проект и создай объекты класса "Person"
   // для выполнения задач, связанных с персонами.
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Person person = new Person();
      person.PrintInfo();
    }
  }
}

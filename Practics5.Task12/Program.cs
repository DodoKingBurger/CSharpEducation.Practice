using Practics5.Task12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Practics5.Task2Lib;
namespace Practics5.Task1
{
  //  1. Класс Employee.Делайте в одном проекте.
  //a.Создайте базовый класс Employee с полями Name и Salary, а также
  //методом CalculateBonus(), который возвращает 10% от зарплаты.
  //Создайте производный класс Manager, который переопределяет метод
  //CalculateBonus(), чтобы возвращать 20% от зарплаты. Создайте объекты
  //обоих классов, вызовите метод и выведите результат на экран.
  //b.Расширьте класс Employee, добавив конструктор, принимающий имя и
  //зарплату. В классе Manager добавьте дополнительное поле TeamSize.
  //Реализуйте конструктор в классе Manager, который вызывает
  //конструктор базового класса с помощью base и устанавливает значение
  //TeamSize. В методе CalculateBonus() учитывайте размер команды: если
  //команда больше 5 человек, бонус должен увеличиваться на 5%.
  //c.Создайте новый класс Contractor, унаследованный от Employee, который
  //добавляет поле HourlyRate и скрывает метод CalculateBonus(), делая его
  //зависящим от отработанных часов. Реализуйте метод CalculateBonus(int
  //hoursWorked). Создайте список сотрудников, включая Contractor, и
  //реализуйте приведение типов, чтобы рассчитать бонусы для всех
  //сотрудников, независимо от типа.
  internal class Program
  {
    static void Main(string[] args)
    {
      
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      ConsoleLogger consoleLogger = new ConsoleLogger(typeof(Program).Name);
      Manager Ivan = new Manager(6,"Ivan", 20000);
      Employee Vasya = new Employee("Vasya");
      Contractor Gosha = new Contractor(5,700, "Gosha");
      var array = new Employee[]
      {
        Ivan,
        Vasya,
        Gosha
      };
      for (int i = 0; i < array.Length; i++)
      {
        array[i].PrintInfo();
      }
    }
  }    
}

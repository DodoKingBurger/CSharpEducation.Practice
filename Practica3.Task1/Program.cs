using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай класс "Студент" с полями "Имя" и "Возраст".Напиши метод, который будет
//выводить информацию о студенте в консоль.
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Student Danil = new Student("Danil", 23);
      Danil.PrintStudentСard();
    }
    class Student
    {
      private string name;
      private int age;
      public Student(string Name, int Age)
      {
        this.name = Name;
        this.age = Age;
      }
      public void PrintStudentСard()
      {
        Console.WriteLine($"Имя студента: {this.name}");
        Console.WriteLine($"Возраст студента: {this.age}");
      }

    }
  }
}

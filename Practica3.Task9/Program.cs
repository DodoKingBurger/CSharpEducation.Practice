using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //      . Создай класс "Студент" с полями "Имя" и "Возраст".Напиши метод, который будет
      //принимать объект класса "Студент" и изменять его имя на "Аноним"
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Student Danil = new Student("Danil",23);
      Danil.PrintStudentСard();
      Anonim(Danil);
      Console.WriteLine("Скрылся");
      Danil.PrintStudentСard();
      void Anonim (Student student)
      {
        student.Name = "Аноним";
      }

    }

    class Student 
    {
      private string name;
      private int age;
      public string Name
      {
        get { return name; }
        set { name = value; }
      }
      public int Age
      {
        get { return age; }
        set { age = value; }
      }
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

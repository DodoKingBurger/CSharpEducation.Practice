using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай класс "Студент" с полями "Имя" и "Возраст".Напиши метод, который будет
//выводить информацию о студенте в консоль. Добавь в класс "Студент" свойство
//"Средний балл".Реализуй геттер и сеттер для этого свойства. Добавь проверку в
//сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Student Danil = new Student("Danil", 23);
      Danil.MidleBall = 4.5f;
      Danil.PrintStudentСard();
    }
    class Student
    {
      private string name;
      private int age;
      private float midleBall;
      public float MidleBall
      {
        get
        {
          return this.midleBall;
        }
        set
        {
          if (value >= 0 && value <= 5)
          {
            midleBall = value;
          }
          else
          {
            throw new ArgumentException("У нас система с баллами от 0 до 5!");
          }
        }
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
        Console.WriteLine($"Средний балл студента: {this.midleBall}");
      }
    }
  }
}

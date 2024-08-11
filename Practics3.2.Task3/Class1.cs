using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics3._2.Task3
{
    public class Person
    {
      private string name;
      private int age;
      public string Name
      {
        get { return this.name; }
        set 
        { 
          if(string.IsNullOrEmpty(value))
            throw new ArgumentNullException("Не бывает человека без имени");
          else
            this.name = value; 
        }
      }
      public int Age
      {
        get { return this.age; }
        set 
        {
          if (value >= 0)
            this.age = value;
          else
            throw new ArgumentException("Человеку не может быть меньше 0 лет");
        }
      }
      public Person(string name = "Райан Гослинг", int age = 43) 
      {
          Name = name;
          Age = age;
      }
      public void PrintInfo ()
      {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст {Age}");
      }
    } 
}

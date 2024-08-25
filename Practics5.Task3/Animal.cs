using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practics5.Task3
{
  internal class Animal
  {
    //		a.Создайте базовый класс Animal с полями Name и Age.Добавьте методы
    //Eat() и Sleep(), которые выводят соответствующие сообщения, например,
    //"Animal is eating" и "Animal is sleeping". Создайте производные классы
    //Dog и Cat, унаследованные от Animal.
    public string Name;
    public int Age;
    public void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }
    public void Eat()
    {
      Console.WriteLine("Animal is eating");
    }
    public virtual void MakeSound()
    {
      Console.WriteLine("Some generic animal sound");
    }
    public Animal(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
  }
}

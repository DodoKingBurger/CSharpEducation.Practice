using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task3
{
  internal class Program
  {
    //		b.Добавьте в класс Animal виртуальный метод MakeSound(), который
    //выводит "Some generic animal sound". Переопределите этот метод в
    //классах Dog и Cat, чтобы они выводили "Woof!" и "Meow!"
    //соответственно.Проверьте работу метода через объекты каждого
    //класса.
    static void Main(string[] args)
    {

      Animal animal = new Animal("Danil", 23);
      Console.WriteLine();
      Dog Bob = new Dog("Bob", 4);
      Console.WriteLine();
      Cat Semyon = new Cat("Semyon", 10);
      Console.WriteLine();
      Parrot Kesha = new Parrot("Kesha", 10, "Зеленый");
      Console.WriteLine();
      List<Animal> animals = new List<Animal>()
      {
        Bob,
        Semyon,
        Kesha
      };
      for (int i = 0; i < animals.Count; i++)
      {
        animals[i].Sleep();
        animals[i].Eat();
        animals[i].MakeSound();
        Console.WriteLine();
      }
      Eagle Nafanya = new Eagle();
      IFlyable[] Birds = new IFlyable[]
      {
        Kesha,
        Nafanya
      };
      Console.WriteLine();
      for (int i = 0; i < Birds.Length; i++)
      {
        Birds[i].Fly();
      }
    }
  }
}

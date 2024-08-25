using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task3
{
  internal class Dog : Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
    public Dog(string name, int age)
  : base(name, age)
    {
      Console.WriteLine($"Какой хороший собачка {this.Name}\nЕму {this.Age} столько годиков");
    }
  }
}

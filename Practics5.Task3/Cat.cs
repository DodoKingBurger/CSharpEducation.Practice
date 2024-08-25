using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task3
{
  internal class Cat : Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
    public Cat(string name, int age)
      : base(name, age)
    {
      Console.WriteLine($"Какой хороший котик {this.Name}\nЕму {this.Age} столько годиков");
    }
  }
}

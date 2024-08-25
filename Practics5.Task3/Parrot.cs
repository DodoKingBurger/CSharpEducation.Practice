using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task3
{
  internal class Parrot : Animal, IFlyable
  {
    public string Color;
    public override void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }
    public void MakeSound(string words)
    {
      Console.WriteLine($"Parrot is talking: {words}");
    }
    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }
    public Parrot(string name, int age, string color)
    : base(name, age)
    {
      this.Color = color;
      Console.WriteLine($"Какой хороший попугайчик {this.Name}\nЕму {this.Age} столько годиков\nОн {this.Color} он вот такого цвета");
    }
  }
}

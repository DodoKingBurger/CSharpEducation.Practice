using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics7.Task2
{
  internal class Person : ICloneable
  {
    public string Name;
    public int Age;

    public object Clone()
    {
      return new Person(this.Name, this.Age);
    }
    public Person(string name, int age) 
    {
      this.Name = name;
      this.Age = age;
    }
  }
}

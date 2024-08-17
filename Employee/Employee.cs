using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practics5.Task1
{
    public class Employee
    {
      private string name;
      
      private float salary;
    
      public string Name
      {
      get { return this.name; }
      set
        {
          this.name = value;
        }
      }
      public float Salary
      {
        get { return this.salary; }
        set { this.salary = value; }
      }
      public virtual float CalculateBonus()
      {
        return (float)(Salary * 0.1);
      }
      public Employee(string name = "Аноним", float salary = 15000)
      {
        Name = name;
        Salary = salary;
      }
    }
}

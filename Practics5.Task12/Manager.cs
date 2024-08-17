using Practics5.Task2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practics5.Task1
{
  internal class Manager : Employee
  {
    //Создайте производный класс Manager, который переопределяет метод
    //CalculateBonus(), чтобы возвращать 20% от зарплаты. Создайте объекты
    //обоих классов, вызовите метод и выведите результат на экран.
    private ILogger Log;
    private int teamSize;
    public int TeamSize { get;set; }
    public override float CalculateBonus()
    {
      Log.Info("Вызван метод CalculateBonus()");
      if (TeamSize > 5)
        return (float)(Salary * 0.25);
      else 
        return (float)(Salary * 0.2);
    }
    public Manager(int teamSize = 1,string name = "Аноним", float salary = 15000) : base(name, salary)
    {
      Log = new ConsoleLogger(typeof(Manager).Name);
      Log.Info("Вызван конструктор Manager");
      TeamSize = teamSize;
    }

  }
}

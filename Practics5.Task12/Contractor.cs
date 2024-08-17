using Practics5.Task1;
using Practics5.Task2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5.Task12
{
  //  Создайте новый класс Contractor, унаследованный от Employee, который
  //добавляет поле HourlyRate и скрывает метод CalculateBonus(), делая его
  //зависящим от отработанных часов.Реализуйте метод CalculateBonus(int
  //hoursWorked). Создайте список сотрудников, включая Contractor, и
  //реализуйте приведение типов, чтобы рассчитать бонусы для всех
  //сотрудников, независимо от типа.

  public class Contractor : Employee
  {
    private ILogger Log;
    private int hourlyRate;
    public int HourlyRate { get { return this.hourlyRate; } set { this.hourlyRate = value; } }
    public override float CalculateBonus()
    {
      Log.Info("Вызван метод CalculateBonus()");
      return CalculateBonus(HourlyRate);
    }
    public float CalculateBonus(int hourlyRate)
    {
      Log.Info("Вызван метод CalculateBonus(int hourlyRate)");
      return (float)(Salary * (hourlyRate*0.1));
    }
    public Contractor(int hourlyRate,int saleryHour,string name = "Аноним") : base(name)
    {
      Log = new ConsoleLogger(typeof(Contractor).Name);
      Log.Info("Вызван конструктор ConsoleLogger");
      Salary = saleryHour * hourlyRate;
      HourlyRate = hourlyRate;
    }
  }
}

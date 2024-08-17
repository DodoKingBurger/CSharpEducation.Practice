using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Practics5.Task2Lib;
namespace Practics5.Task1
{
    //  Класс Employee.Делайте в одном проекте.
    //a.Создайте базовый класс Employee с полями Name и Salary, а также
    //методом CalculateBonus(), который возвращает 10% от зарплаты.
    public class Employee
    {
      private ILogger Log;
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
      public void PrintInfo()
      {
        string messege = $"Имя: {Name} Зарплата: {Salary} Бонусы: {CalculateBonus()}";
        Log.Info(messege);
      }
      public virtual float CalculateBonus()
      {
        Log.Info("Вызван метод CalculateBonus()");
        return (float)(Salary * 0.1);
      }
      public Employee(string name = "Аноним", float salary = 15000)
      {
        Log = new ConsoleLogger(typeof(Employee).Name);
        Log.Info("Вызван конструктор Employee");
        Name = name;
        Salary = salary;
      }

    }
}

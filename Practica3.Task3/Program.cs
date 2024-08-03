using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
//      Создай класс "Калькулятор" с методами для выполнения основных арифметических
//операций(сложение, вычитание, умножение, деление).Пусть эти методы
//принимают два числа и возвращают результат операции.

      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Calculator calculator = new Calculator();
      calculator.Add(5, 5);
      calculator.Subtraction(5, 5);
      calculator.Multiplication(5, 5);
      calculator.Division(5, 5); 
    }
    class Calculator
    {
      public float Add(float Argum1, float Argum2)
      {
        return Argum1 + Argum2;
      }
      public float Subtraction(float Argum1, float Argum2)
      {
        return Argum1 - Argum2;
      }
      public float Multiplication(float Argum1, float Argum2)
      {
        return Argum1 * Argum2;
      }
      public float Division(float Argum1, float Argum2)
      {
        return Argum1 / Argum2;
      }
    }
  }
}

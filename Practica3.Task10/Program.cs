using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //      Создай класс "Автомобиль" с полем "Марка".Напиши метод, который будет
      //принимать объект класса "Автомобиль" и выводить информацию о марке
      //автомобиля в консоль
      Console.OutputEncoding = Encoding.GetEncoding(1251);
      Car Nissan = new Car("JUKE");
      WhatBrand(Nissan);
      void WhatBrand(Car car)
      {
        Console.WriteLine($"Марка машины: {car.Brand}");
      }
    }
    class Car
    {
      private string brand;
      public string Brand
      {
        get { return this.brand; }
        set { this.brand = value; }
      }
      public Car()
      {
        this.Brand = "Неизвестно";
      }
      public Car(string Brand)
      {
        this.Brand = Brand;
      }
    }
  }
}

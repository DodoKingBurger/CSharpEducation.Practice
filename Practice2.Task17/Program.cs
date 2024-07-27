using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте и реализуйте метод, который будет принимать два числа и менять их
            //значения местами.Вызовите метод в Main.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Program mg = new Program();
            int num1 = 1;
            int num2 = 100;
            Console.WriteLine("До метода");
            Console.WriteLine($"Первое число = {num1}");
            Console.WriteLine($"Второе число = {num2}");
            mg.SwitchNumb(ref num1, ref num2);
            Console.WriteLine("После метода");
            Console.WriteLine($"Первое число = {num1}");
            Console.WriteLine($"Второе число = {num2}");
        }
        public void SwitchNumb(ref int num1 , ref int num2)
        {
            int num = num1;
            num1 = num2;
            num2 = num;
        }
    }
}

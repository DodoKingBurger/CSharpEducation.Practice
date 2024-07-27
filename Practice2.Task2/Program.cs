using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
        }


        public void TaskA()
        {
            //Напишите программу, которая переводит:
            //a.метры в километры
            Console.WriteLine("Введитке метры");
            if(float.TryParse(Console.ReadLine(), out float Metrs))
            {
                Console.WriteLine($"Ваши метры в километрах = {Metrs/1000}");
            }
            else
            {
                Console.WriteLine("Ошибка перезапустите программу");
            }
        }

        public void TaskB()
        {
            //Напишите программу, которая переводит:
            //b.километры в сантиметры

            Console.WriteLine("Введитке километры");
            if (float.TryParse(Console.ReadLine(), out float KiloMetrs))
            {
                Console.WriteLine($"Ваши метры в сантиметрах = {KiloMetrs * 1000 * 100}");
            }
            else
            {
                Console.WriteLine("Ошибка перезапустите программу");
            }

        }
        public void TaskC()
        {
            //Напишите программу, которая переводит:
            //c.м/с в км/ч
            Console.WriteLine("Введитке м/с");
            if (float.TryParse(Console.ReadLine(), out float MetrsInSec))
            {
                Console.WriteLine($"Ваши метры в км/ч = {MetrsInSec / 1000/60/60}");
            }
            else
            {
                Console.WriteLine("Ошибка перезапустите программу");
            }

        }
        public void TaskD()
        {
            //Напишите программу, которая переводит:
            //d.градусы C в градусы F
            Console.WriteLine("градусы C");
            if (float.TryParse(Console.ReadLine(), out float TempC))
            {
                Console.WriteLine($"Ваши метры в градусы F = {TempC+ 273}");
            }
            else
            {
                Console.WriteLine("Ошибка перезапустите программу");
            }
        }

    }
}

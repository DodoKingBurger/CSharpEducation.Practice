using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте перечисление(enum) для дней недели.Напишите программу, которая
            //считывает ввод пользователя и в зависимости от его ввода(число от 1 до 7)
            //будет выводиться на экран консоли соответствующий день недели

            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.WriteLine("Приветсвую пользователь\nВведи (число от 1 до 7)будет выводиться на экран консоли соответствующий день недели");
            if (int.TryParse(Console.ReadLine(), out int value)&& (value>= 1 && value<=7))
            {
                Console.WriteLine(Enum.GetName(typeof(Week), value-1));
            }

        }
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

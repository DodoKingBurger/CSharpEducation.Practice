using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public void Task()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //Напишите программу для вычисления выражения
            //(а + b — f / а) + f* a * a — (a +b).
            //Все переменные задаются пользователем.Учтите деление на 0.

            float a = 5;
            float b = 5;
            float f = 5;

            if (a == 0) 
            {
                Console.WriteLine( "Ошибка делить на 0 нельзя");
            }
            else
            {
                Console.WriteLine($"{(a + b - f / a) +f * a * a - (a + b)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //Напишите игру Угадай число. Программа случайно генерирует число от 1 до
            //100, а пользователь пытается угадать это число. При успешной догадке
            //выводите поздравление пользователя.
            Random rnd = new Random();
            int WinNumb = rnd.Next(1,100);
            Console.WriteLine(WinNumb);
            Console.WriteLine("Игра угадай число!!!!!!!!!!!!!!!!!!!!");
            int HowNumb;
            do
            {
                Console.WriteLine("Как думаешь, какое число ?");
              
                if(!int.TryParse(Console.ReadLine(), out HowNumb))
                {
                    continue;
                }

            } while (WinNumb != HowNumb);
            Console.WriteLine("Ты победил");
        }
    }
}

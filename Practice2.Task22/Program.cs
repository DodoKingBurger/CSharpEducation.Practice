using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Напишите игру Угадай число. Программа случайно генерирует число от 1 до
            //100, а пользователь пытается угадать это число. При успешной догадке
            //выводите поздравление пользователя. Также покажите количество попыток,
            //принятых пользователем.
            //  a.Сделайте ограничение по попыткам. Например, если попыток больше 10,
            //  то пользователь проиграл
            //  b.Сделайте подсказки для пользователя. Если предположенное число
            //  больше загаданного, то писать в консоль об этом. Аналогично и для
            //  меньшего числа.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Random rnd = new Random();
            int WinNumb = rnd.Next(1, 100);
            Console.WriteLine(WinNumb);
            Console.WriteLine("Игра угадай число!!!!!!!!!!!!!!!!!!!!");
            int MaxAttempts = 10;
            Console.WriteLine($"Число попыток = {MaxAttempts}");
            bool WinFlag = false;
            int HowNumb;
            int HowAttempts = 0;
            do
            {
                Console.WriteLine("Как думаешь, какое число ?");
                int.TryParse(Console.ReadLine(), out HowNumb);                
                HowAttempts++;  
                if(WinNumb == HowNumb)
                {
                    Console.WriteLine("Ты победил");            
                    Console.WriteLine($"Тебе понадобилось попыток = {HowAttempts}\nТы большой молодец))");
                    WinFlag = true;
                }
                else
                {
                    if (HowNumb > WinNumb)
                    {
                        Console.WriteLine("Твое число больше загаданного");
                    }
                    else
                    {
                        Console.WriteLine("Твое число меньше загаданного");
                    }
                    if ((MaxAttempts - HowAttempts)<= 0)
                    {
                        Console.WriteLine("Ты проиграл :-(");
                        break;
                    }
                Console.WriteLine($"Осталось попыток {MaxAttempts-HowAttempts}");}
            } while (WinFlag!=true);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введите с клавиатуры строку произвольной длины и подсчитайте процент
            //вхождения заданного символа в строку.
                        
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            TaskC();
            void TaskA()
            {
                //a. строка и символ указываются программно
                string str = "argarshaehanadnsdnsdansb";
                char Char = 'a';
                int counter = 0;

                foreach (char CChars in str.ToCharArray())
                {
                    if (Char == CChars) 
                        counter++;
                }
                double ArraMass = str.Length ;
                Console.WriteLine($"процентвхождения заданного символа \'{Char}\' в строку равен = {counter / ArraMass * 100}");
            }

            void TaskB()
            {
                //b.строка и символ указываются пользователем в консоли
                Console.WriteLine("Укажите строку = ");
                string str = Console.ReadLine();
                Console.WriteLine("Укажите Символ = ");
                char Char = Console.ReadLine().ToCharArray()[0];
                int counter = 0;

                foreach (char CChars in str.ToCharArray())
                {
                    if (Char == CChars)
                        counter++;
                }
                double ArraMass = str.Length;
                Console.WriteLine($"процентвхождения заданного символа \'{Char}\' в строку равен = {counter / ArraMass * 100}");
            }
            void TaskC()
            {
                //c. строка и символ указываются через аргументы командной строки
                string str = args[0].ToString();
                char Char = Convert.ToChar(args[args.Length-1]);
                int counter = 0;

                foreach (char CChars in str.ToCharArray())
                {
                    if (Char == CChars)
                        counter++;
                }
                double ArraMass = str.Length;
                Console.WriteLine($"процентвхождения заданного символа \'{Char}\' в строку равен = {counter / ArraMass * 100}");
            }
        }
    }
}

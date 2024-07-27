using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            TaskB();        
            void TaskA()
            {
                Console.Write("Введите симвл для треугольника = ");
                string StrChar = Console.ReadLine();
                Console.Write("Введите высоту треугольника = ");
                if(int.TryParse(Console.ReadLine(), out int h))
                {
                    for(int i = 1; i <= h; i++)
                    {
                        for(int j = 1; j <= i; j++)
                        {
                            Console.Write($"{StrChar}");
                        }
                        Console.WriteLine("\n");
                    }
                }
             }

            void TaskB()
            {
                Console.Write("Введите симвл для треугольника = ");
                string StrChar = Console.ReadLine();
                Console.Write("Введите высоту треугольника = ");
                if (int.TryParse(Console.ReadLine(), out int h))
                {
                    for (int i = 1; i <= h; i++)
                    {
                        for (int j = 1; j <= (h-i); j++)
                        {
                            Console.Write(" ");
                        }
                        for(int k = 1; k <= i; k++)
                        {
                            Console.Write($"{StrChar}");
                        }
                        Console.WriteLine("\n");
                    }
                }

            }

        }

    }
}

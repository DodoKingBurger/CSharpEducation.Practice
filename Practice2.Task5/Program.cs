using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            void Task()
            {
                Console.Write("Введите первое целое число = ");
                if(int.TryParse(Console.ReadLine(), out var Numb1)){
                    Console.Write("Введите второе целое число = ");
                    if (int.TryParse(Console.ReadLine(), out var Numb2))
                    {
                        if (Numb1 > Numb2)
                        {
                            Console.WriteLine("Первое целое число больше второго");
                        }
                        else if (Numb1 < Numb2)
                        {
                            Console.WriteLine("Второе целое число больше первого");
                        }
                        else 
                        { 
                            Console.WriteLine("Числа равны"); 
                        }
                    }
                    else { Console.WriteLine("Второе число невозможно преобразовать в целое"); }
                }
                else { Console.WriteLine("Первое число невозможно преобразовать в целое"); }

            }
        }

    }
}

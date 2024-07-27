using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить алгоритм увеличения всех трех, введенных с клавиатуры,
            //переменных на 5,если среди них есть хотя бы две равные. В противном случае
            //выдать ответ «равных нет».
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Task();
            void Task()
            {
                bool Gotcha = false;
                int[] array = new int[3]; 
                Console.Write("Введите первое число:");
                array[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                array[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите третье число:");
                array[2] = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= array.Length - 1; i++)
                {
                    for (int j = 1; j <= array.Length - 1; j++)
                    {
                        if (array[j] == array[i])
                        {
                            Gotcha = true;
                            break;
                        }
                    }
                }
                if (!Gotcha)
                {
                    Console.WriteLine("Нет равных чисел!");
                }
                else
                {
                    for(int i  = 0; i <= array.Length -1; i++)
                    {
                        Console.WriteLine(array[i]+5);
                    }
                }
            }
        }
    }
}

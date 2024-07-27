using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте двумерный массив целых чисел произвольной длины и заполните
            //случайными числами от 1 до 100.Выведите на экран разницу максимального и
            //минимального значений в каждой строке массива.

            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Random rnd = new Random();
            int rndd = rnd.Next(1, 10);
            int[,] Array = new int[rndd, rndd];
            Console.WriteLine("Сам массив:");
            for (int i = 0; i < rndd - 1; i++)
            {
                for (int j = 0; j < rndd - 1; j++)
                {
                    Array[i,j] = rnd.Next(1, 100);
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < rndd - 1; i++)
            {
                int Max = 0;
                int Min = 100;
                for(int j = 0;j < rndd - 1; j++)
                {
                    if (Array[i,j] > Max)
                        Max = Array[i,j];
                    if (Array[i,j] < Min)
                        Min = Array[i,j];
                }
                Console.WriteLine($"Разницу максимального и минимального значений в {i} строке {Max} - {Min} = {Max - Min}");
            }
            
        }
    }
}

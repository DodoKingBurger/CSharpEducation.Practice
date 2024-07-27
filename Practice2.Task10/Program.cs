using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив и выводится на экран
            //консоли.Размер массива передавайте в качестве первого аргумента командной
            //строки.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Program mg = new Program();
            int length = Convert.ToInt32(args[0]);
            int[] array = mg.CreateArray(length);
            mg.PrintArray(array);
        }
        public int[] CreateArray(int length)
        {
            Console.WriteLine("метод, который создаёт массив целых чисел и возвращает его");
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            return array;
        }
        public void PrintArray(int[] array)
        {
            Console.WriteLine("метод, который выводит переданный массив на экран консоли");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте одномерный массив целых чисел произвольной длины и заполните
            //случайными числами от 1 до 100.Выведите на экран разницу максимального и
            //минимального значений в нём.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Random rnd = new Random();
            int[] Array = new int[rnd.Next(1, 10)];
            Console.WriteLine("Сам массив:");
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(1,100);
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine($"\nРазницу максимального и минимального значений в нём {Array.Max()} - {Array.Min()} = {Array.Max()-Array.Min()}");
            
        }
    }
}

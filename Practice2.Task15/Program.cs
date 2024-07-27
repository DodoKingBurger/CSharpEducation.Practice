using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте и реализуйте метод, который принимает на вход массив и
            //инвертирует его.Вызовите его в методе Main.Исходный массив задайте сами.
            //Инвертированный массив выведите на экран консоли.

            Console.OutputEncoding = Encoding.GetEncoding(1251);
            int[] Array = new int[] { 1, 2, 3, 4, 5 };
            Program mg = new Program();

            Array = mg.InvertArray(Array);
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
        public int[] InvertArray(int[] array)
        {
            int t;
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                t = array[i];
                array[i] = array[j];
                array[j] = t;
            }
            return array;
        }
    }
}

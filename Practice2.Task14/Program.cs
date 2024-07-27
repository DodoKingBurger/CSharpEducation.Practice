using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте и реализуйте метод, который принимает на вход размер массива n и
            //возвращает пустой массив указанного размера. Вызовите метод в методе Main
            //и заполните его полученный массив. Содержимое массива выведите на экран.

           Console.OutputEncoding = Encoding.GetEncoding(1251);
            Program mg = new Program();
            Random rnd = new Random();
            int n = 5;
            var array = mg.CreateArray(n);
            for (int i = 0; i< array.Length; i++)
            {
                array[i] = rnd.Next(1,10);
            }

            for(int i  = 0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public int[] CreateArray (int length)
        {
            int[] array = new int[length];
            return array;
        }

    }
}

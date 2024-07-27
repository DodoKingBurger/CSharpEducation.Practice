using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);

        }


        public void TaskA()
        {
            //a.цикл for. Пусть он выводит в консоль значение своего же счётчика.
            Console.WriteLine("a.цикл for");
            for (int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void TaskB()
        {
            //b.цикл while.Пусть он выводит в консоль значение своего же счётчика.
            Console.WriteLine("b.цикл while");
            int counter = 0;
            while (counter<5)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
        public void TaskC()
        {
            //c.цикл do while.Пусть он выводит в консоль значение своего же счётчика.
            Console.WriteLine("c.цикл do while");
            int counter = 0;
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 5); 

            
        }
        public void TaskD()
        {
            //d.цикл for, в котором у пользователя запрашиваются слова, затем
            //выводится полная фраза, слова в которой разделены пробелами.
            Console.WriteLine("d. цикл for, в котором у пользователя запрашиваются слова, затем\r\nвыводится полная фраза, слова в которой разделены пробелами.\r\n");

            string[] strarray = new string[5];
            for (int counter = 0; counter < strarray.Length; counter++)
            {
                strarray[counter] =Console.ReadLine();
            }
            for (int counter = 0; counter < strarray.Length; counter++)
            {
                Console.Write(strarray[counter] + " ");
            }
        }
        public void TaskE()
        {
            //e.цикл while, в котором у пользователя запрашиваются слова, затем
            //выводится полная фраза, слова в которой разделены пробелами.
            Console.WriteLine("e.цикл while, в котором у пользователя запрашиваются слова, затем\nвыводится полная фраза, слова в которой разделены пробелами.");
            string[] strarray = new string[5];
            int counter = 0;
            while (counter < strarray.Length)
            {
                 strarray[counter] =Console.ReadLine() ;
            }
            while (counter < strarray.Length)
            {
                Console.Write(strarray[counter] + " ");
            }

        }
        public void TaskF()
        {
            //f.цикл do while, в котором у пользователя запрашиваются слова, затем
            //выводится полная фраза, слова в которой разделены пробелами.
            Console.WriteLine("f.цикл do while, в котором у пользователя запрашиваются слова, затем\nвыводится полная фраза, слова в которой разделены пробелами.");
            string[] strarray = new string[5];
            int counter = 0;
            do
            {
                strarray[counter++] =Console.ReadLine();
            } while (counter < strarray.Length);

            do
            {
                Console.Write(strarray[counter++] + " ");
            } while (counter < strarray.Length);

        }

    }
}

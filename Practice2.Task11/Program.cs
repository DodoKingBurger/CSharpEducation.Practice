using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив и выводится на экран
            //консоли.Размер массива передавайте в качестве первого аргумента командной
            //строки.Число, которым будет заполняться массив передайте через второй
            //аргумент командной строки.
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            int length = Convert.ToInt32(args[0]);
            string[] arrayString = new string[length];
            arrayString = args[1].Split(',');
            for(int i = 0; i < length; i++)
            {
                Console.Write(arrayString[i] + " ");
            }
        }
    }
}

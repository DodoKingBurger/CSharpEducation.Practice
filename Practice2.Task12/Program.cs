using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив строк, который заполняется
            //пользователем через консоль. Затем этот массив должен быть выведен на
            //экран консоли.

            string[] arrayString = new string[5];
            for(int i = 0; i < arrayString.Length; i++)
            {
                arrayString[i] = Console.ReadLine();
            }
            for(int i = 0;i < arrayString.Length; i++)
            {
                Console.Write(arrayString[i] + " ");
            }
        }
    }
}

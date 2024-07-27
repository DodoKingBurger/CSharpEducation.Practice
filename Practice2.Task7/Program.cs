using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая переводит строку в разные регистры
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            StringBuilder s = new StringBuilder("привет");

            TaskA("привет");
            TaskB("привет");
            TaskC(s);


            void TaskA(string str)
            {
                //a.в верхний регистр: f->F
                Console.WriteLine(str.ToUpper());
            }
            void TaskB(string str)
            {
                //b.в нижний регистр: F->f
                Console.WriteLine(str.ToLower());
            }
            void TaskC(StringBuilder str)
            {
                //c.делает заглавную букву в слове: привет->Привет
                str[0] = char.ToUpper(str[0]);
                Console.WriteLine(str);
            }
        }
    }
}

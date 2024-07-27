using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Task6_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);


            void TaskA()
            {
                //a. Известны два катета - найти гипотенузу
                //c = √(a² + b²)

                float katit_a = 6;
                float katit_b = 8;



                float hypotenuse = (float)Math.Sqrt(Math.Pow(katit_a, 2) + Math.Sqrt(Math.Pow(katit_b, 2)));
                Console.WriteLine($"{hypotenuse} - Найденная гипотенуза");
            }

            void TaskB()
            {
                //b. Известен один катет и гипотенуза - найти второй катет
                //a = √ (c² — b²) где c — гипотенуза, b — катет который известен прямоугольного

                float katit_b = 5;
                float hypotenuse = 20;

                float katit_a = (float)Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Sqrt(Math.Pow(katit_b, 2)));
                Console.WriteLine($"{katit_a} - Найденная второй катет");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            //a. Известны два катета - найти гипотенузу
            //c = √(a² + b²)

            float katit_a = 6;
            float katit_b = 8;



            float hypotenuse = (float)Math.Sqrt(Math.Pow(katit_a, 2) + Math.Sqrt(Math.Pow(katit_b, 2)));
            Console.WriteLine($"{hypotenuse} - Найденная гипотенуза");
        }
    }
}
